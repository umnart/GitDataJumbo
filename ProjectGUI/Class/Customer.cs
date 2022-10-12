using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGUI
{
    class Customer
    {
        string name = "";
        string Lastname = "";
        string address = "";
        string email = "";

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Lastname1
        {
            get
            {
                return Lastname;
            }

            set
            {
                Lastname = value;
            }
        }
    }
}
