using FoodForYouDL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForYouDL
{
    public class COMMENTSDL : ICOMMENTSDL
    {
        FoodContext _FoodForYouContext = new FoodContext();
        public async Task<bool> AddComment(Comment comment)
        {
            try
            {
                await _FoodForYouContext.Comments.AddAsync(comment);
                await _FoodForYouContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<List<Comment>> GetALLComments(int id)
        {
            List<Comment> Comments = await _FoodForYouContext.Comments.Where(item => item.Recipe.Id == id).ToListAsync();

            return Comments;
        }
    }
}
