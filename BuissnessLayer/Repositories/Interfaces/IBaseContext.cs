using AccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnessLayer.Repositories.Interfaces
{
    public interface IBaseContext
    {
        public ecommerceContext dbContext { get; }
    }
}
