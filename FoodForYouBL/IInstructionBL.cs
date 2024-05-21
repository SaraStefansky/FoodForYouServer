using FoodForYouDTO.DTO;

namespace FoodForYouBL
{
    public interface IInstructionBL
    {
        Task<bool> AddInstruction(InstructionDTO instructionDTO);
        Task<List<InstructionDTO>> GetInstructions(int id);
        Task<bool> RemoveInstruction(int id); 

    }
}