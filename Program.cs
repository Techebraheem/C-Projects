using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public enum ProductCodes
        {
            //enum illustration

            Milk = 0,
            Juice = 1, 
            Tea = 2
        }
        static void Main (String[] args)
        {
            ProductCodes test = ProductCodes.Milk;

           Console.WriteLine ((int)test);
           
        }
    }
}
   

    
 
