using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKTeco.Models;

namespace ZKTeco.Shared
{
    public class CheckUserSession
    {
        private IHttpContextAccessor _httpContextAccessor;
        private readonly ZKTecoDbContext _context;
        public CheckUserSession(ZKTecoDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }
        public bool checkUserSession()
        {
            var email = _httpContextAccessor.HttpContext.Session.GetString("Email");
            var id = _httpContextAccessor.HttpContext.Session.GetString("Id");
            var firstName = _httpContextAccessor.HttpContext.Session.GetString("FirstName");
            var lastName = _httpContextAccessor.HttpContext.Session.GetString("LastName");
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                return false;
            AspNetUser user = _context.AspNetUsers.FirstOrDefault(x => x.Id == int.Parse(id) && x.Email == email);
            if (user == null)
            {
                _httpContextAccessor.HttpContext.Session.Remove("Email");
                _httpContextAccessor.HttpContext.Session.Remove("Id");
                _httpContextAccessor.HttpContext.Session.Remove("FirstName");
                _httpContextAccessor.HttpContext.Session.Remove("LastName");
                return false;
            }
            return true;
        }
    }
}
