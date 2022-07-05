using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OptimaxTest.API.Data.Model;
using OptimaxTest.API.Services.Interfaces;

namespace OptimaxTest.API.Services.Services
{
    public class UserService: IUserService
    {

        private readonly OptimaxDeveloperTestContext _context;
        public UserService(OptimaxDeveloperTestContext context)
        {
            _context = context;
        }

        public async Task<AppUser?> GetAppUserByAppUserID(int ID)
        {
            
            List<AppUser> usersList = await _context.AppUsers.FromSqlRaw("EXEC GetAppUserByAppUserID {0}", ID).ToListAsync();
            return usersList.FirstOrDefault();
        }
    }
}
