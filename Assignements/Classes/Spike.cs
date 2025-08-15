using Assignements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignements.Classes
{
    public class Spike : ICartoonCharacter
    {
        public string Name { get ; set ; }
        public Spike(string name)
        {
            Name = name ;
        }

        public void ShowTalent()
        {
            Console.WriteLine($"Hi I'm {Name}");
            Console.WriteLine("Talent? Scaring Tom with just one growl. Also.. I bake cookies on weekends. Don’t tell\r\nanyone.");
        }
    }
}
