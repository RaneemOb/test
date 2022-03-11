using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Class1
    {
        private string number1;
        private string number2;
        
        public Class1(string number1, string number2)
        {
            this.number1 = number1;
            this.number1 = number2;
        }
        bool parse;
        
        public double Number1
        {
            
            get
            {

              /*  parse = Double.TryParse(number1, out n1);
                if (parse)
                    return n1;*/

                return Convert.ToDouble(number1);


            }
        }
        public double Number2
        {
            

            get
            {


                /* parse = Double.TryParse(number2, out n2);
                 if (parse)
                     return n2;*/

                 return Convert.ToDouble(number2); 
                   

            }
        }

        
       
        public double Sum(double n1,double n2)
        {
            double d1 = n1 - Convert.ToInt32(n1);
            double d2 = n2 - Convert.ToInt32(n2);
            int r1 = Convert.ToInt32(n1);
            int r2 = Convert.ToInt32(n2);
            double sumr = r1 + r2;
            double sumd = d1 + d2;
            if (sumd >= 1.00)
                sumr += 1.00;

            return sumr;

            
        }

        
        public double Sub(double n1, double n2)
        {
          

            return n1-n2;

            

        }

    }
}
