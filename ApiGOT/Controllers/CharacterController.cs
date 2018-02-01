using ApiGOT.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiGOT.Controllers
{
    public class CharacterController : ApiController
    {
        public List<CharacterDTO> GetAllCharacter()
        {
            List<CharacterDTO> list = new List<CharacterDTO>();
            ThronesTournamentManager business = new ThronesTournamentManager();
            

            foreach (var charac in m.GetAllCharacters())
            {
                list.Add(new CharacterDTO(charac));
            }
            return list;
        }
    }
}
