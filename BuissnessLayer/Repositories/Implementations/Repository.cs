using AccessLayer.EF;
using BuissnessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnessLayer.Repositories.Implementations
{
    public class Repository : IRepository
    {
        public readonly ecommerceContext DbContext;

        public Repository(ecommerceContext context)
        {
            this.DbContext = context;
        }
    }
}
