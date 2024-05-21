using AutoMapper;
using FoodForYouDL.Models;
using FoodForYouDL;
using FoodForYouDTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FoodForYouBL
{
    public class CommentsBL : ICommentsBL
    {

        ICOMMENTSDL _CommentsBL;
        private IMapper Mapper;
        public CommentsBL(ICOMMENTSDL commentsBL, IMapper mapper)
        {
            _CommentsBL = commentsBL;
            Mapper = mapper;
        }


        public async Task<bool> AddComments(CommentDTO commentDTO)
        {
            var commentss = Mapper.Map<Comment>(commentDTO);

            return await _CommentsBL.AddComment(commentss);
        }

        public async Task<List<CommentDTO>> GetComments(int id)
        {
            var comments = await Task.Run(() => _CommentsBL.GetALLComments(id));
            List<CommentDTO> CommentDTOs = Mapper.Map<List<CommentDTO>>(comments);
            return CommentDTOs;
        }

    }
}