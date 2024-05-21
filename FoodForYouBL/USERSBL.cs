using AutoMapper;
using FoodForYouDL;
using FoodForYouDTO.DTO;
using FoodForYouDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouBL
{
    public class USERSBL : IUSERSBL
    {

        IUSERSDL _USERSBL;
        private IMapper Mapper;
        public USERSBL(IUSERSDL usersBL, IMapper mapper)
        {
            _USERSBL = usersBL;
            Mapper = mapper;
        }
        public async Task<UserDTO> GetUserbyid(int id)
        {
            var user = await Task.Run(() => _USERSBL.GetUserbyid(id));
            var userDTO = Mapper.Map<UserDTO>(user);
            return userDTO;
        }
        public async Task<UserDTO> Login(UserLoginDTO userLogin)
        {
            var user = await Task.Run(() => _USERSBL.Login(userLogin.email, userLogin.password));
            if (user!= null) {
                var userDTO = Mapper.Map<UserDTO>(user);
                return userDTO;
            }
            return null;
        }
        public async Task<UserDTO> AddUser(UserDTO userDTO)
        {
            var user = Mapper.Map<User>(userDTO);
            User User = await Task.Run(() => _USERSBL.AddUser(user));
            if (User != null)
            {
                var UserDTO = Mapper.Map<UserDTO>(User);
                return UserDTO;
            }
            else
            {
                return null;
            }
            
        }

        public async Task<bool> RemoveUser(int id)
        {
            return await Task.Run(() => _USERSBL.RemoveUser(id));

        }


    }
}
