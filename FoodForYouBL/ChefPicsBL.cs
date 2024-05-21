using AutoMapper;
using FoodForYouDL.Models;
using FoodForYouDL;
using FoodForYouDTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouBL
{
    public class ChefPicsBL : IChefPicsBL
    {
        ICHEF_PICSDL _ChefPicsBL;
        private IMapper Mapper;

        public ChefPicsBL(ICHEF_PICSDL chefPicsBL, IMapper mapper)
        {
            _ChefPicsBL = chefPicsBL;
            Mapper = mapper;

        }
        public async Task<bool> AddChefPic(ChefPicDTO chefPicDTO)
        {
            var chefPic = Mapper.Map<ChefPic>(_ChefPicsBL);
            return await _ChefPicsBL.AddChefPic(chefPic);
        }

        public async Task<List<ChefPicDTO>> GetALLChefPic(int id)
        {
            var ChefPics = await Task.Run(() => _ChefPicsBL.GetALLChefPic(id));
            List<ChefPicDTO> chefPicDTOs = Mapper.Map<List<ChefPicDTO>>(ChefPics);
            return chefPicDTOs;
        }
    }
}
