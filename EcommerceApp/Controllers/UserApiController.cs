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
using Newtonsoft.Json;
using Commons.Response;

namespace EcommerceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserApiController : ControllerBase
    {
        private readonly IUserService _IUserService;
        private IConfiguration _config;
        public UserApiController(IUserService IUserService, IConfiguration config)
        {
            _IUserService = IUserService;
            _config = config;
        }

        private UserAuth GenerateJSONWebToken(User Response)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["AppSettings:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var permClaims = new List<Claim>();
            permClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            permClaims.Add(new Claim("UserId", Response.Id.ToString()));
            permClaims.Add(new Claim("Email", Response.Email));
            permClaims.Add(new Claim(ClaimTypes.Name, Response.UserName));
            permClaims.Add(new Claim("LoggedOn", DateTime.Now.ToString()));

            List<string> list = Response.UserRoles.Select(x => x.WebPageName).ToList();
            foreach (var item in list)
            {
                if (item == null) { continue; }
                permClaims.Add(new Claim(ClaimTypes.Role, item));
            }

            var token = new JwtSecurityToken(_config["AppSettings:Issuer"],
                _config["AppSettings:Issuer"],
                permClaims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials);

            UserAuth userAuth = new UserAuth();
            userAuth.accessToken = new JwtSecurityTokenHandler().WriteToken(token);
            userAuth.refreshToken = userAuth.accessToken;
            userAuth.expiresIn = DateTime.Now.AddDays(1);
            return userAuth;
        }
        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] object request)
        {
            var Gen_User = JsonConvert.DeserializeObject<User>(request.ToString());
            var Results = _IUserService.SignIn(Gen_User);
            var Response = (User)Results.ThisClassList.FirstOrDefault();
            if (Response == null)
            {
                return Forbid();
            }
            else
            {
                var UserAuth = GenerateJSONWebToken(Response);
                return Ok(UserAuth);
            }
        }

        [HttpGet("GetUserByToken")]
        public IActionResult GetUserByToken()
        {
            var UserId = User.FindFirstValue("UserId");
            var Results = _IUserService.GetUserById(new User() { Id = int.Parse(UserId) });
            var Response = (User)Results.ThisClassList.FirstOrDefault();
            if (Response == null)
            {
                return Ok(new ApiResponse() { IsSuccess = false, Message = "Some Error Occured" });
            }
            else
            {
                return Ok(new ApiResponse() { Result = Response, IsSuccess = true, Message = "Request Successful" });
            }
        }
    }
    
}
