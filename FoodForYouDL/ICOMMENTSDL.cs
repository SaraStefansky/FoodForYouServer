using FoodForYouDL.Models;

namespace FoodForYouDL
{
    public interface ICOMMENTSDL
    {
        Task<bool> AddComment(Comment comment);
        Task<List<Comment>> GetALLComments(int id);
    }
}