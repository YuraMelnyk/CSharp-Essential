using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task1_2
{
    public class Cat : AnimalWithTail
    {
        public Cat(string color, float weight, float tailLength) : base(color, weight, tailLength)
        {
            Color = color;
            Weight = weight;
            TailLength = tailLength;
        }
        private string Purr()
        {
            string s = "purrrrrrrr";
            return s;
        }
        private string Meow()
        {
            string s = "Meow";
            return s;
        }

        public override string MakeSound()
        {
            return Purr() + Meow();
        }
        public override string ToString()
        {
            return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }
}
