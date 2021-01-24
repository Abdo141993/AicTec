using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKTeco.Dto.User;
using ZKTeco.Models;
using ZKTeco.Shared;

namespace ZKTeco.Controllers
{
    public class LoginController : Controller
    {
        private readonly ZKTecoDbContext _context;
        public LoginController(ZKTecoDbContext context)
        {
            _context = context;
        }

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginUserDto dto)
        {
            if (ModelState.IsValid)
            {
                #region Check User If Exist in DB
                // Check User If Exist in DB
                AspNetUser user = _context.AspNetUsers.FirstOrDefault(x => x.Email == dto.Email);
                if (user == null)
                {
                    // If User Not Found In DB
                    ModelState.AddModelError("Email", "Email Not Found Please Register New Account.");
                }
                var result = PasswordManagement.VerifyPasswordHash(dto.Password, user.PasswordHash, user.PasswordSalt);
                #endregion

                if (result && user.TwoFactorEnabled)
                {
                    return RedirectToAction("LoginWith2fa", "User");
                }
                else if (result && user.LockoutEnabled)
                {
                    return RedirectToAction("locked", "User");
                }
                else if (result)
                {
                    HttpContext.Session.SetString("Email", dto.Email);
                    HttpContext.Session.SetString("Id", user.Id.ToString());
                    HttpContext.Session.SetString("FirstName", user.FirstName);
                    HttpContext.Session.SetString("LastName", user.LastName);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Password", "Email Or Password Is Wrong.");
                    return View();
                }
            }

            // If we got this far, something failed, redisplay form
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Email");
            HttpContext.Session.Remove("Id");
            HttpContext.Session.Remove("FirstName");
            HttpContext.Session.Remove("LastName");
            return RedirectToAction("Login", "Login");
        }

    }
}
