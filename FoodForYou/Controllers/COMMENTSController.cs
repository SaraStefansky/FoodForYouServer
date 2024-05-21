using FoodForYouBL;
using FoodForYouDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodForYou.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class COMMENTSController : ControllerBase
    {
        ICommentsBL _COMMENTSController;
        public COMMENTSController(ICommentsBL commentsController)
        {
            _COMMENTSController = commentsController;
        }


        // GET api/<PRODUCTSController>/5

        [HttpGet("{id}")]
        public async Task<List<CommentDTO>> GetComments(int id)
        {
            return await _COMMENTSController.GetComments(id);
        }

        [HttpPost]
        public async Task<bool> AddComments(CommentDTO commentDTO)
        {
            return await _COMMENTSController.AddComments(commentDTO);
        }
    }
}
