using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightApplication
{
   public static class Program
    {
       public static void HeightCatgeory(float hght)
        {
          
            if (hght > 150)
            {
                Console.WriteLine("You fall under Dwarf category.");
            }
            else if (hght <= 151 || hght >= 165)
            {
                Console.WriteLine("You fall under average category.");
            }
            else
            {
                Console.WriteLine("You fall under tall category.");
            }
        }


        static void Main(string[] args)
        {
            float   height = 0;
            Console.WriteLine("Kindly enter your height in centimeters.");
            //String.Format("{0:0.00}", 123.4567m);
           decimal  ht = decimal.Parse(Console.ReadLine());
             //height = float.Parse(String.Format("{0:0.00", ht));

            HeightCatgeory(height);
            Console.ReadLine();
        }
    }
}
