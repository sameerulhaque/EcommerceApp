using BuissnessLayer.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuissnessLayer.Repositories.Interfaces
{
    public interface IBaseRepo : IDisposable
    {
        IProductRepo Product { get; }
        public AppSettings AppSettings { get; }
    }
}
