using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_D_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int flaga = 0,flagb=0;
            int maininput;

            main:
            mainclass ob = new mainclass();
            try
            {
                ob.mainmenu(flaga, flagb);
                maininput = int.Parse(Console.ReadLine());
                switch (maininput)
                {
                    case 1:

                        break;



                    default:
                        break;
                }
            }
            catch(Exception)
            {
                mainclass ex = new mainclass();
                ex.invalidinput();
                goto main;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            Console.ReadLine();


        }
    }
}
