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
    public class ChefBL : IChefBL
    {
        ICHEFSDL _ChefBL;
        private IMapper Mapper;

        public ChefBL(ICHEFSDL chefBL, IMapper mapper)
        {
            _ChefBL = chefBL;
            Mapper = mapper;

        }

        public async Task<ChefDTO> AddChef(ChefDTO chefDTO)
        {
            var chef = Mapper.Map<Chef>(chefDTO);
            Chef Chef= await Task.Run(() => _ChefBL.AddChef(chef));
            if (Chef != null)
            {
                var ChefDTO = Mapper.Map<ChefDTO>(Chef);
                return ChefDTO;
            }
            else
            {
                return null;
            }
        }
        public async Task<List<ChefDTO>> GetAllChefsByServiceId(int serviceId)
        {
            var ChefsByServiceId = await Task.Run(() => _ChefBL.GetAllChefsByServiceId(serviceId));
            List<ChefDTO> ChefsByServiceIdDTO = Mapper.Map<List<ChefDTO>>(ChefsByServiceId);
            return ChefsByServiceIdDTO;
        }
        public async Task<List<ChefDTO>> GetAllChefs()
        {
            var AllChefs = await Task.Run(() => _ChefBL.GetAllChefs());
            List<ChefDTO> AllChefsDTO = Mapper.Map<List<ChefDTO>>(AllChefs);
            return AllChefsDTO;
        }
        public async Task<ChefDTO> GetChefById(int chefId)
        {
            var ChefById = await Task.Run(() => _ChefBL.GetChefById(chefId));
            ChefDTO ChefByIdDTO = Mapper.Map<ChefDTO>(ChefById);
            return ChefByIdDTO;
        }

        public async Task<bool> UpdateChef(ChefDTO chefDTO)
        {
            var currentchef = Mapper.Map<Chef>(chefDTO);
            return await Task.Run(() => _ChefBL.UpdateChef(currentchef));

        }
        public async Task<ChefDTO> ChefLogin(ChefLoginDTO chefLogin)
        {
            var chef = await Task.Run(() => _ChefBL.ChefLogin(chefLogin.email, chefLogin.password));
            if (chef != null)
            {
                var chefDTO = Mapper.Map<ChefDTO>(chef);
                return chefDTO;
            }
            return null;
        }
    }
}
