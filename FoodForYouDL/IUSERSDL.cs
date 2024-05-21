using FoodForYouDL.Models;

namespace FoodForYouDL
{
    public interface IUSERSDL
    {
        Task<User> AddUser(User user);
        Task<User> GetUserbyid(int id);
        Task<User> Login(string email, string password);
        Task<bool> RemoveUser(int id);
    }
}