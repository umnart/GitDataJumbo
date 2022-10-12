using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGUI.Class
{
    class Cat :  Animal
    {
        string NameCat;

        public string NameCat1
        {
            get
            {
                return NameCat;
            }

            set
            {
                NameCat = value;
            }
        }

        public string cry()
        {
            return "Meaowwwwwwwwwwwww !";
        }

    }
}
