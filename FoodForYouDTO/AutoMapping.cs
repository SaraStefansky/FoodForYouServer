using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoodForYouDL.Models;
using FoodForYouDTO.DTO;
using Type = FoodForYouDL.Models.Type;
using static AutoMapper.Profile;


namespace FoodForYouDTO
{
    public class AutoMapping: Profile
    {
        public AutoMapping() 
        {
            CreateMap<Area, AreaDTO>().ReverseMap();
            CreateMap<Askthechef, AskthechefDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Chef, ChefDTO>().ReverseMap();
            CreateMap<Comment, CommentDTO>().ReverseMap();
            CreateMap<ChefPic, ChefPicDTO>().ReverseMap();
            CreateMap<Instruction, InstructionDTO>().ReverseMap();
            CreateMap<Level, LevelDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Recipe, RecipeDTO>().ReverseMap();
            CreateMap<RecipesLike, RecipesLikeDTO>().ReverseMap();
            CreateMap<ServicesColinar, ServicesColinarDTO>().ReverseMap();
            CreateMap<Type, TypeDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();


        }
    }
}
