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
    public class ProductController : ControllerBase
    {
        private readonly IProductService _IProductService;
        public ProductController(IProductService IProductService)
        {
            _IProductService = IProductService;
        }

        #region Product
        [Authorize(Roles = USERROLES.VIEWORDER)]
        [HttpPost("GetAllProduct")]
        public IActionResult GetAllProduct(Commons.TableSearching.DataTable<Commons.InventoryUtilities.Product> request)
        {
            try
            {
                var ProductObj = request.filter.Data;
                ProductObj.DataTable = request;

                var Results = _IProductService.GetAllProducts(ProductObj);
                var items = Results.ThisClassList;
                return Ok(new { items = items, total = Results.TotalRecords });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return NotFound();
            }

        }

        [Authorize(Roles = USERROLES.ADDPRODUCT)]
        [HttpPost("AddProduct")]
        public IActionResult AddProduct(object item)
        {
            try
            {
                var ProductObj = JsonConvert.DeserializeObject<Commons.InventoryUtilities.Product>(item.ToString());
                ProductObj = _IProductService.AddProduct(ProductObj);

                var Product = new Commons.InventoryUtilities.Product();
                Product.Id = ProductObj.Id;
                Product.IsDescriptive = true;
                var Results = _IProductService.GetAllProducts(Product);
                ProductObj = (Commons.InventoryUtilities.Product)Results.ThisClassList.FirstOrDefault();

                return Ok(new ApiResponse { Result = ProductObj, IsSuccess = ProductObj.DataSaved, Message = ProductObj.Message });

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return Ok(new ApiResponse { Result = new Commons.InventoryUtilities.Product(), IsSuccess = false, Message = "Error Occured" });
            }

        }

        //[Authorize(Roles = USERROLES.UPDATEPRODUCT)]
        //[HttpPost("UpdateProduct")]
        //public IActionResult UpdateProduct(object item)
        //{
        //    try
        //    {
        //        var ProductObj = JsonConvert.DeserializeObject<Commons.InventoryUtilities.Product>(item.ToString());
        //        ProductObj = _IProductService.AddProduct(ProductObj);
        //        return Ok(new ApiResponse { Result = ProductObj, IsSuccess = ProductObj.DataSaved, Message = ProductObj.Message });
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //        return Ok(new ApiResponse { Result = new Commons.InventoryUtilities.Product(), IsSuccess = false, Message = "Error Occured" });
        //    }

        //}
        #endregion
    }
}
