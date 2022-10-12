using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGUI.Class
{
    class Square : Shapes
    {

        int side = 0;

        public int Side
        {
            get
            {
                return side;
            }

            set
            {
                side = value;
            }
        }

        public override int Area()
        {
            return side * side;
            
        }
    }
}
