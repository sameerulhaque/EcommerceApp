using Commons.InventoryUtilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.Services.Interfaces
{
    public interface IProductService
    {
        public Product GetAllProducts(Product Product);
        public Product AddProduct(Product Product);
    }
}
