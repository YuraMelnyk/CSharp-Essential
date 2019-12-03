using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task1_2
{
    public abstract class AnimalWithTail : Animal
    {
        public float TailLength { get; set; }

        public AnimalWithTail(string color, float weight, float tailLength) : base(color, weight)
        {
            Color = color;
            Weight = weight;
            TailLength = tailLength;
        }
    }
}
