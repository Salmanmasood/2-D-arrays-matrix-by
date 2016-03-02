using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_D_arrays
{
    class class2
    {
        public void adddisplay(int[,] a, int[,] b, int[,] c, int ra, int ca, int rb, int cb)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("============================Adding MATRIces============================");
            Console.ForegroundColor = ConsoleColor.White;
            class2 ob = new class2();
           bool x= ob.cmpforadd(ra, ca, rb, cb);
           if (x==true)
           {
               for (int i = 1; i < ra; i++)
               {
                   for (int j =1 ; j < ca; j++)
                   {
                       c[i, j] = a[i, j] + b[i, j];
                       
                   }

               }

           }
           
           else
               {
                     Console.ForegroundColor = ConsoleColor.Magenta;
                   Console.WriteLine("Matrices cannot be added....");
                     Console.ForegroundColor = ConsoleColor.White;

               }



        }

        public bool cmpforadd(int ra,int ca,int rb,int cb)
        {
            bool x = false;
            if (ra==rb && ca==cb)
            {
                x = true;
            }
            return x;

        }







    }
}
