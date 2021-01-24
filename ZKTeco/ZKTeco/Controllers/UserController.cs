using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKTeco.Dal;
using ZKTeco.Dto.User;
using ZKTeco.Models;
using ZKTeco.Shared;

namespace ZKTeco.Controllers
{
    public class UserController : Controller
    {
        private readonly UserDal _userDal;
        public UserController(UserDal userDal)
        {
            _userDal = userDal;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult LoginWith2fa()
        {
            return View();
        }
        public IActionResult locked()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        // POST: User/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            if (ModelState.IsValid)
            {
                ErrorEnum result = await _userDal.Register(dto);
                if (result == ErrorEnum.EmailAlreadyExist)
                {
                    ModelState.AddModelError("Email", "Email Already Exist.");
                    return View();
                }
                else if (result == ErrorEnum.UserNotSaved)
                {
                    ModelState.AddModelError("Email", "User Not Registerd Please Try Later.");
                    return View();
                }
                else
                    return RedirectToAction("Login", "Login");
            }
            return View();
        }
    }
}
