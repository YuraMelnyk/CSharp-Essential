using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_PartyPlanner
{
    class DinnerParty : Party
    {
        
        
        public bool HealthyOption { get; set; }        
        public override decimal Cost {
            get {
                decimal totalCost;
                totalCost = base.Cost + (CalculateCostOfBeveragesPerPerson()   * NumberOfPeople);
                if (HealthyOption)
                {
                    return totalCost * 0.95M;
                }
                else
                {
                    return totalCost;
                }
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations) 
        {
            NumberOfPeople = numberOfPeople;            
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }
        

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal totalCost = 0.0M;
            if (!HealthyOption)
            {
               return totalCost += 20.0M;
            }
            else
            {
                return totalCost += 5.0M;
            }
        }
    }
}