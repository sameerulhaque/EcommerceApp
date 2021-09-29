using Commons;
using Commons.InventoryUtilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLayer.Services.Interfaces
{
    public interface IUserService
    {
        public User SignIn(User User);
    }
}
