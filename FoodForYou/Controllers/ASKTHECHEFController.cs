using FoodForYouBL;
using FoodForYouDL.Models;
using FoodForYouDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodForYou.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ASKTHECHEFController : ControllerBase
    {
        IAskthechefBL _ASKTHECHEFController;
        public ASKTHECHEFController(IAskthechefBL askthechefController)
        {
            _ASKTHECHEFController = askthechefController;
        }

        // GET: api/<ASKTHECHEFController>   
        [HttpPost]
        public async Task<bool> Addaskthechef(AskthechefDTO askthechef)
        {
            return await Task.Run(() => _ASKTHECHEFController.Addaskthechef(askthechef));
        }


        // GET: api/<ASKTHECHEFController>
        [HttpGet("{id}")]
        public async Task<List<AskthechefDTO>> GetAllaskthechef(int id)
        {
            return await Task.Run(() =>  _ASKTHECHEFController.GetAllaskthechef(id));
        }
        }
}
