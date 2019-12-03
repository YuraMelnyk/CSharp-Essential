using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_ModelingHome
{
    class Outside : Location
    {
        public Outside(string name, bool hot): base(name)
        {
            this.hot = hot;
        }
        private bool hot;
        public bool Hot
        {
            get
            {
                return hot;
            }
        }
    }
}
