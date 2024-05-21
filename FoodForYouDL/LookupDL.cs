using FoodForYouDL.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Type = FoodForYouDL.Models.Type;

namespace FoodForYouDL
{
    public class LookupDL : ILookupDL
    {
        FoodContext _FoodForYouContext = new FoodContext();
        public async Task<List<ServicesColinar>> GetAllServicesColinar()
        {
            try
            {
                List<ServicesColinar> servicesColinars = await _FoodForYouContext.ServicesColinars.ToListAsync();
                return servicesColinars;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<List<Level>> GetAllLevels()
        {
            try
            {
                List<Level> levels = await _FoodForYouContext.Levels.ToListAsync();
                return levels; ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<List<Area>> GetAllAreas()
        {
  

            try
            {
                List<Area> areas = await _FoodForYouContext.Areas.ToListAsync();
                return areas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Type>> GetAllTypes()
        {
            try
            {
                List<Type> types = await _FoodForYouContext.Types.ToListAsync();
                return types;
            }
            catch (Exception ex)
            {
                throw ex;
            }
         
        }

        public async Task<List<Category>> GetAllCategories()
        {
            try
            {
                List<Category> categories = await _FoodForYouContext.Categories.ToListAsync();
                return categories;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
