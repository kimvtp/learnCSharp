using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "ABC";
        public int Hitpoint { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Intelligence { get; set; } = 10;

        public Class1 Class { get; set; } = Class1.Knight;
        public User User { get; set; }
    }
}
