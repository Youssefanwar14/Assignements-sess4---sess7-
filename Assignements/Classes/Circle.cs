using Assignements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignements.Classes
{
    public class Circle : ICircle
    {
      
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;

        public Circle(double raduis)
        {
            Radius = raduis;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape => Circle");
            Console.WriteLine($"Raduis => {Radius}");
            Console.WriteLine($"Area => {Area:F}");
        }
    }
}
