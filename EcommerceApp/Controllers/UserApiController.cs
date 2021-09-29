using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BuissnessLayer;
//using ERP.Models.EF;
using Commons;
using Commons.Inventory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using EcommerceApp.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using BuissnessLayer.Helpers;
using ServicesLayer.Services.Interfaces;
using BuissnessLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Hosting;

namespace EcommerceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserApiController : ControllerBase
    {
        private readonly IUserService _IUserService;
        public UserApiController(IUserService IUserService)
        {
            _IUserService = IUserService;
        }

        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] User userParam)
        {
            var user = UserAuthenticate(userParam);
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                user = new UserAuth();
                return Ok(user);
            }
        }

        [HttpGet("GetUserByToken")]
        public IActionResult GetUserByToken()
        {
            //var user = manager.GetAllUsers(new User() { Email = User.Identity.Name });
            User user = new User();
            user.Id = 1;
            user.UserName = "Sameer";
            user.Email = "Admin";
            user.Roles = new List<int> { 1 };
            user.FullName = "Sameer";
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                user = new User();
                return Ok(user);
            }
        }

        public UserAuth UserAuthenticate(User User)
        {
            User user = new User();
            user = _IUserService.SignIn(User);
            if (user.Id == 0)
                return null;

            var permClaims = new List<Claim>();
            permClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            permClaims.Add(new Claim("valid", "1"));
            permClaims.Add(new Claim("UserId", user.Id.ToString()));
            permClaims.Add(new Claim(ClaimTypes.Name, user.Email));
            permClaims.Add(new Claim("UserName", user.UserName));
            permClaims.Add(new Claim("Name", user.Email));
            permClaims.Add(new Claim("LoggedOn", DateTime.Now.ToString()));


            List<string> list = user.UserRoles.Select(x => x.WebPageName).ToList();
            foreach (var item in list)
            {
                if (item == null)
                {
                    continue;
                }
                permClaims.Add(new Claim(ClaimTypes.Role, item));
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            string Secret = "my_secret_key_12345";
            var key = Encoding.ASCII.GetBytes(/*_appSettings.*/Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(permClaims),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);


            UserAuth userAuth = new UserAuth();
            userAuth.accessToken = new JwtSecurityTokenHandler().WriteToken(token);
            userAuth.refreshToken = new JwtSecurityTokenHandler().WriteToken(token);
            userAuth.expiresIn = DateTime.Now.AddDays(1);
            return userAuth;
        }
    }
    
}
