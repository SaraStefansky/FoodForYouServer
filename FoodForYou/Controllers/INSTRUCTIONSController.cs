using FoodForYouBL;
using FoodForYouDL;
using FoodForYouDL.Models;
using FoodForYouDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodForYou.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class INSTRUCTIONSController : ControllerBase
    {
        IInstructionBL _INSTRUCTIONSController;
        public INSTRUCTIONSController(IInstructionBL instructionController)
        {
            _INSTRUCTIONSController = instructionController;
        }

        [HttpGet("{id}")]
        public async Task<List<InstructionDTO>> GetInstructions(int id)
        {
            return await _INSTRUCTIONSController.GetInstructions(id);
        }

        [HttpPost]
        public async Task<bool> AddInstruction(InstructionDTO InstructionsDTO)
        {
            return await _INSTRUCTIONSController.AddInstruction(InstructionsDTO);
        }
        // Delete api/<INSTRUCTIONSController>
        [HttpDelete("{id}")]
        public async Task<bool> RemoveInstruction(int id)

        {
            return await _INSTRUCTIONSController.RemoveInstruction(id);
        }
    }
}
