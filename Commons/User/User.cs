using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public class User : AbstractEntity
    {

        public bool success;
        public string message;

        public User()
        {
            WebPages = new List<WebPages>();
            UserRoles = new List<UserRoles>();
            UserList = new List<User>();
            Address = new Address();
            SocialNetworks = new SocialNetwork();

        }

        public string Password { get; set; }
        public decimal StartingAmount { get; set; }
        public int CompanyCostCenterId { get; set; }
        public int StoreId { get; set; }
        public string ShowPassword { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public UserTypes UserType { get; set; }
        public int? UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public string RandomPassword { get; set; }
        public int ActionId { get; set; }
        public string Mobile { get; set; }
        public Guid ActivationCode { get; set; }
        public List<WebPages> WebPages { get; set; }
        public List<UserRoles> UserRoles { get; set; }
        public string Cnic { get; set; }
        public List<User> UserList { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        //public string Address { get; set; }
        public List<int> Roles { get; set; }
        public Address Address { get; set; }
        public SocialNetwork SocialNetworks { get; set; }
        public string UserName { get; set; }
    }
}
