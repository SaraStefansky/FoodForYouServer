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
    public class AskthechefBL : IAskthechefBL
    {
        IASKTHECHEFDL _AskthechefBL;
        private IMapper Mapper;
        public AskthechefBL(IASKTHECHEFDL askthechefBL, IMapper mapper)
        {
            _AskthechefBL = askthechefBL;
            Mapper = mapper;
        }
        public async Task<bool> Addaskthechef(AskthechefDTO askthechefDTO)
        {

            var askthechef = Mapper.Map<Askthechef>(askthechefDTO);

            return await _AskthechefBL.AddAskTheChef(askthechef);
        }
        public async Task<List<AskthechefDTO>> GetAllaskthechef(int id)
        {
            var Askthechef = await Task.Run(() => _AskthechefBL.GetAllAskthechefs(id));
            List<AskthechefDTO> askthechefDTOs = Mapper.Map<List<AskthechefDTO>>(Askthechef);
            return askthechefDTOs;
        }
    }
}
