using Commons.Response;
using EcommerceApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ServicesLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _IOrderService;
        
        public OrderController(IOrderService IOrderService)
        {
            _IOrderService = IOrderService;
        }

        #region Order
        [Authorize(Roles = USERROLES.VIEWORDER)]
        [HttpPost("GetAllOrder")]
        public IActionResult GetAllOrder(Commons.TableSearching.DataTable<Commons.Inventory.Order> request)
        {
            try
            {
                var OrderObj = request.filter.Data;
                OrderObj.DataTable = request;

                var Results = _IOrderService.GetAllOrders(OrderObj);
                var items = Results.ThisClassList;
                return Ok(new { items = items, total = Results.TotalRecords });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return NotFound();
            }

        }

        [Authorize(Roles = USERROLES.ADDORDER)]
        [HttpPost("AddOrder")]
        public IActionResult AddOrder(object item)
        {
            try
            {
                var OrderObj = JsonConvert.DeserializeObject<Commons.Inventory.Order>(item.ToString());
                OrderObj = _IOrderService.AddOrder(OrderObj);

                var Order = new Commons.Inventory.Order();
                Order.Id = OrderObj.Id;
                Order.IsDescriptive = true;
                var Results = _IOrderService.GetAllOrders(Order);
                OrderObj = (Commons.Inventory.Order)Results.ThisClassList.FirstOrDefault();

                return Ok(new ApiResponse { Result = OrderObj, IsSuccess = OrderObj.DataSaved, Message = OrderObj.Message });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return Ok(new ApiResponse { Result = new Commons.Inventory.Order(), IsSuccess = false, Message = "Error Occured" });
            }

        }
        #endregion
    }
}
