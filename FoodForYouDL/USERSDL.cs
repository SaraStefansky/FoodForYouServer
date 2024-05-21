using FoodForYouDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodForYouDL.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodForYouDL
{
    public class USERSDL : IUSERSDL
    {
        FoodContext _FoodForYouContext = new FoodContext();

        public async Task<User> Login(string email, string password)
        {
            try
            {
                User currentUser = await _FoodForYouContext.Users.SingleOrDefaultAsync(item => item.Email.Equals(email) && item.Password.Equals(password));

                return currentUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> GetUserbyid(int id)
        {
            try
            {
                User currentUser = await _FoodForYouContext.Users.SingleOrDefaultAsync(item => item.Id == id);
                if (currentUser == null)
                {
                    throw new ArgumentException($"{id} is not found");
                }


                return currentUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<User> AddUser(User user)
        {
            try
            {
                await _FoodForYouContext.Users.AddAsync(user);
                await  _FoodForYouContext.SaveChangesAsync();
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> RemoveUser(int id)
        {
            try
            {
                User currentUser = await _FoodForYouContext.Users.FirstOrDefaultAsync(item => item.Id == id);
                if (currentUser == null)
                {
                    throw new ArgumentException($"{id} is not found");
                }
                _FoodForYouContext.Users.Remove(currentUser);
                await _FoodForYouContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
