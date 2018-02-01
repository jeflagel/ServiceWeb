using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiGOT.Models
{
    public class CharacterDTO
    {
        public CharacterDTO() { }
        public String Fistname { get; set; }
        public String Lastname { get; set; }
        public int PV { get; set; }
    }
}