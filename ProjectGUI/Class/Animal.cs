using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGUI.Class
{
    class Animal
    {
        int insizeOfAnimal = 0;

        public int InsizeOfAnimal
        {
            get
            {
                return insizeOfAnimal;
            }

            set
            {
                insizeOfAnimal = value;
            }
        }

        public string breathing()
                    {
            return "I'm Ok";

        }
        public string move()
        {
            return "Go Go Go !";
        }



    }

}
