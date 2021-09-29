using AccessLayer.EF;
using BuissnessLayer.Helpers;
using BuissnessLayer.Repositories.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnessLayer.Repositories.Implementations
{
    public class BaseRepo : IBaseRepo
    {
        private readonly ecommerceContext _context;
        private AppSettings _AppSettings;
        private ProductRepo _Product;

        public BaseRepo(ecommerceContext context, IOptions<AppSettings> AppSettings)
        {
            this._context = context;
            this._AppSettings = AppSettings.Value;
        }

        public IProductRepo Product => _Product = _Product ?? new ProductRepo(_context);
        public AppSettings AppSettings => _AppSettings = _AppSettings ?? new AppSettings();

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
