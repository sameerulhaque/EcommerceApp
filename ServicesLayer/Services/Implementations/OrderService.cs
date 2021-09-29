using AccessLayer.EF;
using BuissnessLayer.Repositories.Implementations;
using BuissnessLayer.Repositories.Interfaces;
using Commons;
using Commons.Inventory;
using Commons.InventoryUtilities;
using Commons.Stores;
using Commons.Utilities;
using Microsoft.EntityFrameworkCore;
using ServicesLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ServicesLayer.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IBaseRepo _IBaseRepo;
        private readonly ecommerceContext dbContext;
        public OrderService(IBaseRepo IBaseRepo, ecommerceContext context)
        {
            this._IBaseRepo = IBaseRepo;
            this.dbContext = context;
        }

        public Order GetAllOrders(Order Order)
        {
            var query = dbContext.inv_order.AsQueryable();
            #region Sorting
            if (String.IsNullOrEmpty(Order.DataTable.sortField))
            {
                Order.DataTable.sortField = "order_id";
                Order.DataTable.sortOrder = "asc";
            }
            var type = typeof(AccessLayer.EF.inv_order);
            var prop = type.GetProperty(Order.DataTable.sortField);
            if (prop != null)
            {
                var param = Expression.Parameter(type);
                var expr = Expression.Lambda<Func<AccessLayer.EF.inv_order, object>>(Expression.Convert(Expression.Property(param, prop), typeof(object)), param);
                query = Order.DataTable.sortOrder == "asc" ? query.OrderBy(expr) : query.OrderByDescending(expr);
            }
            #endregion
            
                #region Searching

                if (Order.Id > 0)
                {
                    query = query.Where(x => x.order_id == Order.Id);
                }
                if (Order.CompanyId > 0)
                {
                    query = query.Where(x => x.company_id == Order.CompanyId);
                }
                if (!string.IsNullOrEmpty(Order.TransactionNumber))
                {
                    query = query.Where(x => x.transaction_number.ToUpper().StartsWith(Order.TransactionNumber.ToUpper()));
                }
                #endregion
                Order.TotalRecords = query.Count();
                #region Pagination
                if (Order.DataTable.pageNumber > 0)
                {
                    query = query.Skip((Order.DataTable.pageNumber - 1) * Order.DataTable.pageSize);
                    query = query.Take(Order.DataTable.pageSize);
                }
                #endregion
            #region Selection
            var itemList = new List<inv_order>();
            if (Order.IsDescriptive)
            {
                itemList = query
                    .Include(x => x.company)
                    .Include(x => x.customer)
                    .Include(x => x.str_gin_detail).ThenInclude(x => x.product)
                    .Include(x => x.str_gin_detail).ThenInclude(x => x.unit_of_measure)
                    .Include(x => x.str_gin_detail).ThenInclude(x => x.currency)
                    .ToList(); 
            }
            else
            {
                itemList = query
                    .Include(x => x.company)
                    .Include(x => x.customer)
                    .ToList();
            }

            var OrderList = new List<Order>();
            foreach (var item in itemList)
            {
                Order order = new Order();
                order.Id = item.order_id;
                order.TransactionNumber = item.transaction_number;

                order.CompanyId = item.company_id;
                order.Company = new Company() { CompanyName = item.company.company_name, Id = item.company_id ?? 0 };

                order.CustomerId = item.customer_id;
                order.Customer = new Customer() { CustomerName = item.customer.name, Id = item.customer_id ?? 0 };

                order.NetAmount = item.net_amount;
                order.Date = item.date;
                order.DateString = (item.date ?? DateTime.Now).ToString("dd/MM/yyyy");

                #region GIN
                var str_gin_detail = item.str_gin_detail.Where(x => x.is_active == 1).ToList();
                foreach (var str in str_gin_detail)
                {
                    GINDetail gINDetail = new GINDetail();
                    gINDetail.ProductId = str.product_id;
                    gINDetail.Product = new Product() { ProductName = str.product.product_name, Id = str.product_id ?? 0 };

                    gINDetail.UnitId = str.unit_of_measure_id;
                    gINDetail.Unit = new UnitOfMeasure() { UnitOfMeasureName = str.unit_of_measure.unit_of_measure_name, Id = str.unit_of_measure_id ?? 0 };

                    gINDetail.CurrencyId = str.currency_id;
                    gINDetail.Currency = new Currency() { CurrencyName = str.currency.currency_name, Id = str.currency_id ?? 0 };

                    gINDetail.ExchangeRate = str.exchange_rate;
                    gINDetail.Amount = str.amount;
                    gINDetail.Quantity = str.quantity;
                    gINDetail.Date = str.date;
                    order.GINDetailList.Add(gINDetail);
                }
                #endregion

           
                order.DateCreated = item.created_date.HasValue == true ? item.created_date.Value : DateTime.Now;
                order.DateModified = item.modified_date.HasValue == true ? item.modified_date.Value : DateTime.Now;
                order.CreatedBy = item.created_by.HasValue == true ? item.created_by.Value : 0;
                order.ModifiedBy = item.modified_by.HasValue == true ? item.modified_by.Value : 0;

                OrderList.Add(order);
            }
            Order.ThisClassList = OrderList.Cast<Object>().ToList();
            #endregion
            return Order;
        }
        public Order AddOrder(Order order)
        {
            inv_order inv_Order = new inv_order();
            inv_Order.transaction_number = "";
            inv_Order.company_id = order.CompanyId == 0 ? null : order.CompanyId;
            inv_Order.customer_id = order.CustomerId == 0 ? null : order.CustomerId;
            inv_Order.net_amount = order.NetAmount;
            try
            {
                var Date = DateTime.Now;
                DateTime.TryParse(order.DateString, out Date);
                inv_Order.date = Date;
            }
            catch (Exception)
            {

            }
            foreach (var product in order.GINDetailList)
            {
                str_gin_detail str_gin_detail = new str_gin_detail();
                str_gin_detail.product_id = product.ProductId == 0 ? null : product.ProductId;
                str_gin_detail.unit_of_measure_id = product.UnitId == 0 ? null : product.UnitId;
                str_gin_detail.currency_id = product.CurrencyId == 0 ? null : product.CurrencyId;
                str_gin_detail.exchange_rate = product.ExchangeRate;
                str_gin_detail.amount = product.Amount;
                str_gin_detail.quantity = product.Quantity;
                str_gin_detail.date = DateTime.Now;
                str_gin_detail.created_date = DateTime.Now;
                str_gin_detail.modified_date = DateTime.Now;
                str_gin_detail.created_by = 1;
                str_gin_detail.modified_by = 1;
                str_gin_detail.is_active = 1;
                str_gin_detail.is_locked = 1;
                str_gin_detail.import_gin_detail_id = "0";
                str_gin_detail.remarks = "";
                inv_Order.str_gin_detail.Add(str_gin_detail);
            }
            dbContext.inv_order.Add(inv_Order);
            dbContext.SaveChanges();
            order.Message = "Product Added Successfully";
            order.Id = inv_Order.order_id;
            return order;
        }
    }
}
