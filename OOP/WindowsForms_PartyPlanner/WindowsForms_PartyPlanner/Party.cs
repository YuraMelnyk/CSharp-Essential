using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_PartyPlanner
{
    class Party
    {
        public const decimal CostOfFoodPerPerson = 25.0M;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        virtual public decimal Cost
        {
            get
            {
                decimal totalCost;
                if (NumberOfPeople <= 12)
                    return totalCost = CalculateCostOfDecorations() + (CostOfFoodPerPerson * NumberOfPeople);
                else
                    return totalCost = CalculateCostOfDecorations() + (CostOfFoodPerPerson * NumberOfPeople) + 100M;
            }
        }

        //public Party(int numberOfPeople, bool fancyDecorations)
        //{
        //    NumberOfPeople = numberOfPeople;
        //    FancyDecorations = fancyDecorations;
        //}

        private decimal CalculateCostOfDecorations()
        {
            decimal totalCost;
            if (FancyDecorations)
                return totalCost = (NumberOfPeople * 15.00M) + 50.0M;
            else
                return totalCost = (NumberOfPeople * 7.50M) + 30.0M;
        }
    }
}
