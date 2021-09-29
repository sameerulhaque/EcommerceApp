using AccessLayer.EF;
using BuissnessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BuissnessLayer.Repositories.Implementations
{
    public class ProductRepo : Repository, IProductRepo
    {
        public ProductRepo(ecommerceContext context) : base(context) { }
        private ecommerceContext dbContext { get { return DbContext as ecommerceContext; } }

    }
}

