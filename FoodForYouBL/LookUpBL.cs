using FoodForYouDL.Models;
using FoodForYouDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoodForYouDTO.DTO;
using Type = FoodForYouDL.Models.Type;

namespace FoodForYouBL
{
    public class LookUpBL : ILookUpBL
    {
        ILookupDL _LookUpBL;
        private IMapper Mapper;
        public LookUpBL(ILookupDL loOkUpBL, IMapper mapper)
        {
            _LookUpBL = loOkUpBL;
            Mapper = mapper;
        }
        public async Task<List<AreaDTO>> GetAllAreas()
        {
            var Areas = await Task.Run(() => _LookUpBL.GetAllAreas());
            List<AreaDTO> AreaDTOs = Mapper.Map<List<AreaDTO>>(Areas);
            return AreaDTOs;
        }

        public async Task<List<CategoryDTO>> GetAllCategories()
        {
            var Categories = await Task.Run(() => _LookUpBL.GetAllCategories());
            List<CategoryDTO> CategoryDTOs = Mapper.Map<List<CategoryDTO>>(Categories);
            return CategoryDTOs;
        }

        public async Task<List<LevelDTO>> GetAllLevels()
        {
            var Levels = await Task.Run(() => _LookUpBL.GetAllLevels());
            List<LevelDTO> LevelDTOs = Mapper.Map<List<LevelDTO>>(Levels);
            return LevelDTOs;
        }

        public async Task<List<ServicesColinarDTO>> GetAllServicesColinar()
        {
            var ServicesColinars = await Task.Run(() => _LookUpBL.GetAllServicesColinar());
            List<ServicesColinarDTO> ServicesColinarDTOs = Mapper.Map<List<ServicesColinarDTO>>(ServicesColinars);
            return ServicesColinarDTOs;
        }

        public async Task<List<TypeDTO>> GetAllTypes()
        {
            var Types = await Task.Run(() => _LookUpBL.GetAllTypes());
            List<TypeDTO> TypeDTOs = Mapper.Map<List<TypeDTO>>(Types);
            return TypeDTOs;
        }

    }
}
