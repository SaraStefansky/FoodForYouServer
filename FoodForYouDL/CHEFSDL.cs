using FoodForYouDL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouDL
{
    public class CHEFSDL : ICHEFSDL
    {
        FoodContext _FoodForYouContext = new FoodContext();
        public async Task<Chef> ChefLogin(string email, string password)
        {
            try
            {
                Chef currentChef = await _FoodForYouContext.Chefs.FirstOrDefaultAsync(item => item.Email.Equals(email) && item.Password.Equals(password));

                return currentChef;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Chef> GetChefById(int chefId)
        {
            try
            {
                Chef currentChef = await _FoodForYouContext.Chefs.SingleOrDefaultAsync(item => item.Id == chefId);
                if (currentChef == null)
                {
                    throw new ArgumentException($"{chefId} is not found");
                }


                return currentChef;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<Chef>> GetAllChefs()
        {
            List<Chef> AllChefs = await _FoodForYouContext.Chefs.ToListAsync();
            return AllChefs;
        }
        public async Task<List<Chef>> GetAllChefsByServiceId(int serviceId)
        {
            try
            {
                List<Chef> ChefsByService = await _FoodForYouContext.Chefs.Where(item => item.ServiceId == serviceId)
             .ToListAsync();
                if (ChefsByService == null)
                {
                    throw new ArgumentException($"{serviceId} is not found");
                }


                return ChefsByService;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public async Task<Chef> AddChef(Chef chef)
        {
            try
            {
                await _FoodForYouContext.Chefs.AddAsync(chef);
                await _FoodForYouContext.SaveChangesAsync();
                return chef;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<bool> UpdateChef(Chef chef)
        {
            try
            {
                if (chef == null)
                {
                    throw new ArgumentNullException(nameof(chef), "chef object cannot be null.");
                }

                Chef currentChef = await _FoodForYouContext.Chefs.SingleOrDefaultAsync(item => item.Id == chef.Id);
                if (currentChef == null)
                {
                    throw new ArgumentException($"chef with Id {chef.Id} is not found.");
                }

                currentChef.LastName = chef.LastName;
                currentChef.FirstName = chef.FirstName;
                currentChef.Email = chef.Email;
                currentChef.Password = chef.Password;
                currentChef.AreaId = chef.AreaId;
                currentChef.ServiceId = chef.ServiceId;
                currentChef.Desc = chef.Desc;
                currentChef.UrlWebsite = chef.UrlWebsite;
                currentChef.Kosher = chef.Kosher;
                currentChef.Phone = chef.Phone;

                await _FoodForYouContext.SaveChangesAsync();

                return true;
            }
            catch (DbUpdateException ex)
            {
                // Handle the database update exception appropriately
                throw new Exception("An error occurred while updating the chef in the database.", ex);
            }
            catch (Exception ex)
            {
                // Handle other exceptions or rethrow if necessary
                throw;
            }
        }
    }
}
