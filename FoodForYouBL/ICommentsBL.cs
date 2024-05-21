using FoodForYouDTO.DTO;

namespace FoodForYouBL
{
    public interface ICommentsBL
    {
        Task<bool> AddComments(CommentDTO commentDTO);
        Task<List<CommentDTO>> GetComments(int id);
    }
}