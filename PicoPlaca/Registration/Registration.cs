using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    public abstract class Registration
    {
        private String number;

        public String Number
        {
            get { return number; }
            set { number = value; }
        }
        private String country_name;

        public String Country_Name
        {
            get { return country_name; }
            set { country_name = value; }
        }

        public Registration()
        { }
        public Registration(String number)
        {
            this.Validator(number);
        }

        public abstract void Validator(String number);
    }
}
