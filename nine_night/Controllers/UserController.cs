using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace nine_night.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly SqlConnection userDBService;

        public UserController(SqlConnection userRepository)
        {
            userDBService = userRepository;
        }

 
        [HttpGet]
        [Route("text")]
        public string user(int id)
        {
            return id.ToString();
        }





    }
}
