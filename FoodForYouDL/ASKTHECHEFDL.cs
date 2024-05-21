using FoodForYouDL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouDL
{
    public class ASKTHECHEFDL : IASKTHECHEFDL
    {
        FoodContext _FoodForYouContext = new FoodContext();
        public async Task<bool> AddAskTheChef(Askthechef askthechef)
        {
            try
            {

                DateTime currentDate = DateTime.Now;
                askthechef.Date= currentDate;
                await _FoodForYouContext.Askthechefs.AddAsync(askthechef);
                _FoodForYouContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<Askthechef>> GetAllAskthechefs(int id)
        {
            try
            {
                List<Askthechef> Askthechefs = await _FoodForYouContext.Askthechefs.Where(item => item.ChefId == id).ToListAsync();
                return Askthechefs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
