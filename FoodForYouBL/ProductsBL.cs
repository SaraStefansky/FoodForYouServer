using FoodForYouDL.Models;
using FoodForYouDL;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodForYouDTO.DTO;

namespace FoodForYouBL
{
    public class ProductsBL : IProductsBL
    {
        IPRODUCTSDL _ProductsBL;
        private IMapper Mapper;

        public ProductsBL(IPRODUCTSDL productsBL, IMapper mapper)
        {
            _ProductsBL = productsBL;
            Mapper = mapper;

        }
        public async Task<bool> AddProduct(ProductDTO ProductsDTO)
        {
            var product = Mapper.Map<Product>(ProductsDTO);
            return await _ProductsBL.AddProduct(product);
        }

        public async Task<List<ProductDTO>> GetProducts(int id)
        {
            var Products = await Task.Run(() => _ProductsBL.GetProducts(id));
            List<ProductDTO> ProductDTOs = Mapper.Map<List<ProductDTO>>(Products);
            return ProductDTOs;
        }
        public async Task<bool> RemoveProduct(int id)
        {
            return await Task.Run(() => _ProductsBL.RemoveProduct(id));

        }
    }
}
