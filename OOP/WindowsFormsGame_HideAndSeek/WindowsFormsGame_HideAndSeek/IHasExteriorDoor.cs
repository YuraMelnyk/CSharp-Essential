using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_ModelingHome
{
    interface IHasExteriorDoor
    {
         string DoorDescription { get;  }
        Location DoorLocation { get; set; }
    }
}
