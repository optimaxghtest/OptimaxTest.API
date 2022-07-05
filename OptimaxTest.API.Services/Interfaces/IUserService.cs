using OptimaxTest.API.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimaxTest.API.Services.Interfaces
{
    public  interface IUserService
    {
        public Task<AppUser>? GetAppUserByAppUserID(int ID);
    }
}
