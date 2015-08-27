using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Registration
{
    public class EcuadorRegistration : Registration
    {
        public EcuadorRegistration()
        { }
        
        public EcuadorRegistration(String number)
        {
            this.Validator(number);
        }

        /*public String EcuadorNumber
        {
            get { return base.Number; }
            set { base.Number = value; }
        }*/
 
        /*protected String EcuadorCountryName
        {
            get { return base.Country_name; }
            set { base.Country_name = value; }
        }*/

        public override void Validator(String number)
        {

            try
            {
                Regex regex = new Regex(@"^[A-Z]{3,3}\-[0-9]{3,4}$");
                
                Match match = regex.Match(number);

                if (match.Success)
                {
                    base.Number = number;

                    base.Country_Name = Country.country_name.Ecuador.ToString();
                }
                else
                    throw new Exception("La matrícula no es válida para " + Country.country_name.Ecuador.ToString());
            }
            catch (Exception)
            {
                
                throw new Exception("La matrícula no es válida para " + Country.country_name.Ecuador.ToString());
            }           
            
        }
    }
}
