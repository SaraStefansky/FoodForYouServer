using FoodForYouDTO.DTO;

namespace FoodForYouBL
{
    public interface IAskthechefBL
    {
        Task<bool> Addaskthechef(AskthechefDTO askthechefDTO);
        Task<List<AskthechefDTO>> GetAllaskthechef(int id);
    }
}