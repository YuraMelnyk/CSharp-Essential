using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task1_2
{
    public abstract class Animal
    {
        public float Weight { get; set; }
        public string Color { get; set; }
        public Animal(string color, float weight)
        {
            Color = color;
            Weight = weight;
        }
        public abstract string MakeSound();
    }
}
