using AccessLayer.EF;
using BuissnessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnessLayer.Repositories.Implementations
{
    public class BaseContext : IBaseContext
    {
        protected ecommerceContext _context;
        public BaseContext(ecommerceContext context)
        {
            this._context = context;
        }

        public ecommerceContext dbContext => _context;
    }
}
