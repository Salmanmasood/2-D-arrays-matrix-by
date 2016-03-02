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
           L1:
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine("Press 'd' or 'D' to diplay the matrix A\nPress 'm' or 'M' to go in the main menu... ");
               char d = char.Parse(Console.ReadLine());
               Console.ForegroundColor = ConsoleColor.White;
               if (d == 'd' || d == 'D')
               {
                   matrixoperation displayobj = new matrixoperation();
                   char m = 'C';
                   displayobj.display(c, ra, ca, m);
                   mainclass ob2 = new mainclass();
                   ob2.goback();
               }
               else if (d == 'm' || d == 'M')
               {
                   mainclass ob2 = new mainclass();
                   ob2.goback();
               }
               else
               {
                   mainclass ob2 = new mainclass();
                   ob2.invalidinput();
                   goto L1;
               }

           
           }
           
           else
               {
                     Console.ForegroundColor = ConsoleColor.Magenta;
                   Console.WriteLine("Matrices cannot be added....");
                     Console.ForegroundColor = ConsoleColor.White;

               }



        }

        public void subdisplay(int[,] a, int[,] b, int[,] c, int ra, int ca, int rb, int cb)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("============================Adding MATRIces============================");
            Console.ForegroundColor = ConsoleColor.White;
            class2 ob = new class2();
            bool x = ob.cmpforadd(ra, ca, rb, cb);
            if (x == true)
            {
                for (int i = 1; i < ra; i++)
                {
                    for (int j = 1; j < ca; j++)
                    {
                        c[i, j] = a[i, j] - b[i, j];

                    }

                }
            L1:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Press 'd' or 'D' to diplay the matrix A\nPress 'm' or 'M' to go in the main menu... ");
                char d = char.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                if (d == 'd' || d == 'D')
                {
                    matrixoperation displayobj = new matrixoperation();
                    char m = 'C';
                    displayobj.display(c, ra, ca, m);
                    mainclass ob2 = new mainclass();
                    ob2.goback();
                }
                else if (d == 'm' || d == 'M')
                {
                    mainclass ob2 = new mainclass();
                    ob2.goback();
                }
                else
                {
                    mainclass ob2 = new mainclass();
                    ob2.invalidinput();
                    goto L1;
                }

         
         
            
            
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Matrices cannot be Subtracted....");
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
        public bool cmpformul(int ra,int ca,int rb,int cb)
        {
            bool x = false;
            if (ca == rb )
            {
                x = true;
            }
            return x;

        }

        public void multiplymat(int[,]a,int[,]b,int[,]c,int ra,int ca,int rb,int cb)
        {
            class2 v2 = new class2();
         bool x=   v2.cmpformul(ra, ca, rb, cb);
         if (x == false)
         {
             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.WriteLine("Matrices cannot be Multpilied....");
             Console.ForegroundColor = ConsoleColor.White;
         }
         else
         {
             for (int i = 1; i <= ra; i++)
             {
                 for (int j = 1; j <= ca; j++)
                 {
                     for (int k = 1; k <= ca; k++)
                     {
                         c[i, j] += a[i, k] * b[k, j];
                     }
                 }
             }
         }
        } //end of method....


        public void determinant(float[,]a,int r,int c)
        {
            float temp = 0;
            //method of determinant
            for (int i = 1; i <= r; i++)
            {
                a[1, i] = a[1, i] / a[1, 1]; //making 1st a[1,1] =1 dividing the 1st row by a[1,1] 
            }
            //reduction started
            for (int i = 2; i <= r; i++)
            {
                temp = a[1, i];
                for (int j = 1; j <= c; j++)
                {



                    if (a[1, i] < 0)
                    {
                        a[1, i] = a[1, i] * (-1);

                    }



                    a[j, i] = (a[j, i] - (a[j, 1] * temp));


                }
            }

        }


        public void displayrowslice(int[,]a,int r,int c)
        {
            Console.Write("Enter the row # that you want to see: ");
            int ri = int.Parse(Console.ReadLine());
            if (ri > r)
            {
                Console.WriteLine("The row {0} doesnot exist....", ri);
            }
            else
            {

                for (int j = 1; j <= c; j++)
                {
                    Console.Write(a[ri, j] + "\t");
                }



            }


        } //end of method.....
        public void diplaycolumnslice(int[,] a, int r, int c)
        {
            Console.Write("Enter the column # that you want to see: ");
            int ri = int.Parse(Console.ReadLine());
            if (ri > r)
            {
                Console.WriteLine("The row {0} doesnot exist....", ri);
            }
            else
            {

                for (int j = 1; j <= c; j++)
                {
                    Console.WriteLine(a[j, ri]);
                }



            }

        }





    }
}
