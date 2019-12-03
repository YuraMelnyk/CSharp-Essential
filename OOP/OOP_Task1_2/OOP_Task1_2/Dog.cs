using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task1_2
{
    public class Dog : AnimalWithTail
    {
        public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength)
        {
            Color = color;
            Weight = weight;
            TailLength = tailLength;
        }
        public override string MakeSound()
        {
            return "Woof";
        }
        public override string ToString()
        {
            return $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }
}
