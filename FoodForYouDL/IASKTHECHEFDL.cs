using FoodForYouDL.Models;

namespace FoodForYouDL
{
    public interface IASKTHECHEFDL
    {
        Task<bool> AddAskTheChef(Askthechef askthechef);
        Task<List<Askthechef>> GetAllAskthechefs(int id);
    }
}