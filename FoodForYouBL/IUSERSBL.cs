using FoodForYouDTO.DTO;

namespace FoodForYouBL
{
    public interface IUSERSBL
    {
        Task<UserDTO> AddUser(UserDTO userDTO);
        Task<UserDTO> GetUserbyid(int id);
        Task<UserDTO> Login(UserLoginDTO userLoginDTO);
        Task<bool> RemoveUser(int id);
    }
}