using FoodForYouBL;
using FoodForYouDL.Models;
using FoodForYouDTO.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodForYou.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class USERSController : ControllerBase
    {
        IUSERSBL _USERSController;
        public USERSController(IUSERSBL uSERSController)
        {
            _USERSController = uSERSController;
        }
        // POST api/<USERSController>
        [HttpPost]
        public async Task<ActionResult<UserDTO>> AddUser([FromBody] UserDTO userDTO)
        {
            // Task < ActionResult < UserDTO >>
            if (userDTO != null)
            {
                UserDTO user = await _USERSController.AddUser(userDTO);
                if (user != null)
                {
                    return Ok(user);
                }
            
            else
            {
                return NoContent();
            }
            }
            return null;


        }


        // Get api/<USERSController>
        [HttpGet("{id}")]

        public async Task<UserDTO> GetUserbyid(int id)

        {
            return await _USERSController.GetUserbyid(id);
        }

        // Get api/<USERSController>

        [HttpPost("Login")]

        public async Task<ActionResult<UserDTO>> Login([FromBody] UserLoginDTO user)

        {
            UserDTO userDTO= await _USERSController.Login(user);
            if(userDTO != null)
            {
                return Ok(userDTO);
            }
            else
            {
                return NoContent();
            } 
        }


        // Delete api/<USERSController>
        [HttpDelete("{id}")]
        public async Task<bool> RemoveUser(int id)

        {
        return await _USERSController.RemoveUser(id);
        }



    }
}
