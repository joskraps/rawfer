
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Rawfer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Rawfer.Server.Controllers
{
    using Rawfer.Shared.Models;

    [Produces("application/json")]
    [Route("api/Accounts")]
    [Authorize]
    public class AccountsController : Controller
    {
        private UserManager<UserModelApi> _userManager;
        private SignInManager<UserModelApi> _signInManager;

        public AccountsController(UserManager<UserModelApi> userManager,SignInManager<UserModelApi> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<UserModel> LoginAsync([FromBody]UserModel user)
        {
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Role, "Administrator")
                };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties
            {
                AllowRefresh = false,
                // Refreshing the authentication session should be allowed.

                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                // The time at which the authentication ticket expires. A 
                // value set here overrides the ExpireTimeSpan option of 
                // CookieAuthenticationOptions set with AddCookie.

                IsPersistent = false,
                // Whether the authentication session is persisted across 
                // multiple requests. Required when setting the 
                // ExpireTimeSpan option of CookieAuthenticationOptions 
                // set with AddCookie. Also required when setting 
                // ExpiresUtc.

                IssuedUtc = DateTimeOffset.UtcNow,
                // The time at which the authentication ticket was issued.
                //RedirectUri = <string>
                // The full path or absolute URI to be used as an http 
                // redirect response value.
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            return new UserModel()
            {
                Username = "jskraps"
            };
        }

        [HttpGet]
        [Route("providers")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginProviders()
        {
            return Ok((await _signInManager.GetExternalAuthenticationSchemesAsync())
                .Select(s => new SigninProviderViewModel()
                {
                    Name = s.Name,
                    DisplayName = s.DisplayName
                }));
        }
    }
}