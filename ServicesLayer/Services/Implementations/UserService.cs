using AccessLayer.EF;
using BuissnessLayer.Repositories.Implementations;
using BuissnessLayer.Repositories.Interfaces;
using Commons;
using Commons.InventoryUtilities;
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
    public class UserService : IUserService
    {
        private readonly IBaseRepo _IBaseRepo;
        private readonly ecommerceContext dbContext;
        public UserService(IBaseRepo IBaseRepo, ecommerceContext context)
        {
            this._IBaseRepo = IBaseRepo;
            this.dbContext = context;
        }

        public User SignIn(User User)
        {
            var IsUserExist = dbContext.ut_user
                .Where(x => x.user_name.ToLower() == User.Email.ToLower()
                && x.password == User.Password)
                .Select(x => new User()
                {
                    Id = x.user_id,
                    UserName = x.user_name,
                    UserRoles = x.ut_user_role.Select(y => new UserRoles()
                    {
                        Id = y.user_role_id,
                        WebPageId = y.action_id,
                        UserId = y.user_id,
                        WebPageName = y.action.action_name,
                    }).ToList(),
                    ShowPassword = x.show_password,
                    Email = x.email,
                    Mobile = x.mobile
                }).FirstOrDefault();

            if (IsUserExist == null)
            {
                return new User();
            }
            return IsUserExist;
        }

        public User GetUserById(User User)
        {
            var IsUserExist = dbContext.ut_user
                .Where(x => x.user_id == User.Id)
                .Select(x => new User()
                {
                    Id = x.user_id,
                    UserName = x.user_name,
                    Email = x.email,
                    Mobile = x.mobile
                }).FirstOrDefault();

            if (IsUserExist == null)
            {
                return new User();
            }
            return IsUserExist;
        }

    }
}
