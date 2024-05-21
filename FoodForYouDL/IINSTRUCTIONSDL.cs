using FoodForYouDL.Models;

namespace FoodForYouDL
{
    public interface IINSTRUCTIONSDL
    {
        Task<bool> AddInstructions(Instruction instructions);
        Task<List<Instruction>> GetInstructions(int id);
        Task<bool> RemoveInstruction(int id);
    }
}