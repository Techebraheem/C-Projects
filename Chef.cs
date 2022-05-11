using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("the chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("the chef makes salad");       
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("the chef makes bbq ribs");
        }
    }
    internal class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("the Italian Chef can also make pasta");
        }

        //method overriding 

        public override void MakeSpecialDish()
        {
            Console.WriteLine("the chef makes chicken parm");
        }
    }

    class Programs 
    {
      static void Main (string[] args)
        {
            //inheritance illustraions<<
            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef chef1 = new ItalianChef();
            chef1.MakeSpecialDish();
        }
    }


}
