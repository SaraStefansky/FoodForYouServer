using FoodForYouDL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouDL
{
    public class INSTRUCTIONSDL : IINSTRUCTIONSDL
    {
        FoodContext _FoodForYouContext = new FoodContext();

        public async Task<bool> AddInstructions(Instruction instructions)
        {
            try
            {
                await _FoodForYouContext.Instructions.AddAsync(instructions);
                await _FoodForYouContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Instruction>> GetInstructions(int id)
        {
            List<Instruction> instructions = await _FoodForYouContext.Instructions
                .Where(item => item.RecipeId == id)
                .ToListAsync();

            return instructions;
        }
        public async Task<bool> RemoveInstruction(int id)
        {
            try
            {
                Instruction currentInstruction = await _FoodForYouContext.Instructions.FirstOrDefaultAsync(item => item.Id == id);
                if (currentInstruction == null)
                {
                    throw new ArgumentException($"{id} is not found");
                }
                _FoodForYouContext.Instructions.Remove(currentInstruction);
                await _FoodForYouContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
