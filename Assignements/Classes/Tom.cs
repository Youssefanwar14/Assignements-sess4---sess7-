using Assignements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignements.Classes
{
    public class Tom : ICartoonCharacter
    {
        public string Name { get; set; }
        public Tom(string name)
        {
            Name = name;
        }

        public void ShowTalent()
        {
            Console.WriteLine($"Hi, I'm {Name}");
            Console.WriteLine("My talent? I chase Jerry all day... and my own traps. It's a skill!");
        }
    }
}
