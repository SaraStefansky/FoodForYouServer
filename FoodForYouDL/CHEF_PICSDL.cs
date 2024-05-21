using FoodForYouDL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouDL
{
    public class CHEF_PICSDL : ICHEF_PICSDL
    {
        FoodContext _FoodForYouContext = new FoodContext();
        public async Task<bool> AddChefPic(ChefPic chefPic)
        {
            try
            {
                await _FoodForYouContext.ChefPics.AddAsync(chefPic);
                await _FoodForYouContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<List<ChefPic>> GetALLChefPic(int id)
        {
            try
            {
                List<ChefPic> ChefPics = await _FoodForYouContext.ChefPics.Where(item => item.Chef.Id == id).ToListAsync();

                return ChefPics;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
