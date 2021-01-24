using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKTeco.Dto.User;
using ZKTeco.Models;
using ZKTeco.Shared;

namespace ZKTeco.Dal
{
    public class UserDal
    {
        private readonly ZKTecoDbContext _context;
        public UserDal(ZKTecoDbContext context)
        {
            _context = context;
        }

        public async Task<ErrorEnum> Register(RegisterDto dto)
        {
            AspNetUser user = _context.AspNetUsers.FirstOrDefault(x => x.Email == dto.Email);
            if (user != null)
                return ErrorEnum.EmailAlreadyExist;
            byte[] PasswordHashed, PasswordSalt;
            PasswordManagement.GetPasswordHash(dto.Password, out PasswordHashed, out PasswordSalt);
            AspNetUser newUser = new AspNetUser
            {
                Email = dto.Email,
                EmailConfirmed = true,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                LockoutEnabled = false,
                TwoFactorEnabled = false,
                PasswordHash = PasswordHashed,
                PasswordSalt = PasswordSalt
            };
            await _context.AspNetUsers.AddAsync(newUser);
            var addResult = await _context.SaveChangesAsync();
            if (addResult <= 0)
                return ErrorEnum.UserNotSaved;
            return ErrorEnum.Success;
        }

    }
}
