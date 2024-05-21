using FoodForYouDL.Models;
using FoodForYouDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoodForYouDTO.DTO;

namespace FoodForYouBL
{
    public class InstructionBL : IInstructionBL
    {
        IINSTRUCTIONSDL _InstructionBL;
        private IMapper Mapper;
        public InstructionBL(IINSTRUCTIONSDL instructionBL, IMapper mapper)
        {
            _InstructionBL = instructionBL;
            Mapper = mapper;
        }
        public async Task<bool> AddInstruction(InstructionDTO instructionDTO)
        {
            var instruction = Mapper.Map<Instruction>(instructionDTO);
            return await _InstructionBL.AddInstructions(instruction);
        }

        public async Task<List<InstructionDTO>> GetInstructions(int id)
        {
            var Instructions = await Task.Run(() => _InstructionBL.GetInstructions(id));
            List<InstructionDTO> InstructionDTOs = Mapper.Map<List<InstructionDTO>>(Instructions);
            return InstructionDTOs;
        }
        public async Task<bool> RemoveInstruction(int id)
        {
            return await Task.Run(() => _InstructionBL.RemoveInstruction(id));

        }

    }
}
