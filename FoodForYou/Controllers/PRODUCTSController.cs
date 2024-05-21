using FoodForYouBL;
using FoodForYouDL.Models;
using FoodForYouDTO.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodForYou.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PRODUCTSController : ControllerBase
    {
        IProductsBL _PRODUCTSController;
        public PRODUCTSController(IProductsBL productsController)
        {
            _PRODUCTSController = productsController;
        }


        // GET api/<PRODUCTSController>/5

        [HttpGet("{id}")]
        public async Task<List<ProductDTO>> GetProducts(int id)
        {
        return await _PRODUCTSController.GetProducts(id);   
        }

        [HttpPost]
        public async Task<bool> AddProduct(ProductDTO ProductsDTO)
        {
        return await _PRODUCTSController.AddProduct(ProductsDTO);
        }
        // Delete api/<PRODUCTSController>
        [HttpDelete("{id}")]
        public async Task<bool> RemoveProduct(int id)

        {
            return await _PRODUCTSController.RemoveProduct(id);
        }

    }
}
