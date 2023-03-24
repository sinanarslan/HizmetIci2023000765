using MebFinalApp.Business.Abstract;
using MebFinalApp.Model.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MebFinalApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagerController : ControllerBase
    {

        IUserBs userBS;
        public UserManagerController(IUserBs userBS)
        {
            this.userBS = userBS;
        }

        [HttpGet]
        [Route("TumunuGetir")]
        public List<User> Get()
        {
            List<User> users = userBS.GetAll(null);

            return users;
        }

        [HttpGet]
        [Route("{id}")]
        public User Get(int id)
        {
            User users = userBS.Get(x => x.Id == id);

            return users;
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if (user == null)
            {

                return BadRequest();
            }
            else
            {
                userBS.Insert(user);
                return Ok(user);
            }

        }
    }
}
