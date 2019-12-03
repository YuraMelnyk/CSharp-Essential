using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms_ModelingHome;

namespace WindowsFormsGame_HideAndSeek
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidePlaceName) : base(name, hot)
        {
            HidingPlaceName = hidePlaceName;
        }

        public string HidingPlaceName { get;}

        public override string Description
        {
            get
            {
                return base.Description + $"You can hide in {HidingPlaceName}.";
            }
        }
    }
}
