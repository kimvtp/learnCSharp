using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Dto.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "ABC";
        public int Hitpoint { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Intelligence { get; set; } = 10;

        public Class1 Class { get; set; } = Class1.Knight;
    }
}
