using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OptimaxTest.API.Services.Interfaces;
using OptimaxTest.API.Data.Model;

namespace OptimaxTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("GetAppUserByAppUserID/{appUserID}")]
        public async Task<ActionResult<AppUser?>> GetUserByUserID(int appUserID)
        {
            try
            {

                AppUser? appUser = await _userService.GetAppUserByAppUserID(appUserID);
                return appUser != null ? Ok(appUser) : NotFound(appUserID);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
