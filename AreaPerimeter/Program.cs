using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {



            string restarting;

            char  restartApps;



            // looping  

            bool restart = true;

             while( restart )
            {
               

              

                
                   // length

                    Console.WriteLine(" Welcome to Grand Circus Room Detail Generator \n");

                    Console.WriteLine(" Length : \n");

                    double length = double.Parse(Console.ReadLine());

                    Console.WriteLine("\n");

                    // end length


                    // width  and total area

                    Console.WriteLine(" Width : \n ");

                    //double width = 46;

                    //double penthouse = 65;

                    // validate user input  

                    double width = double.Parse(Console.ReadLine());

                    double totalArea = length * width;

                    Console.WriteLine("\n");

                    Console.WriteLine("The  length  of " + length + " and  width of " + width + " is " + totalArea + " total area .");

                    Console.WriteLine("\n");

                    // end width and total area 


                   //perimeter length
                   Console.WriteLine("Perimeter  = Length:\n");

                   double lengthPerimeter = double.Parse(Console.ReadLine());

                   Console.WriteLine("\n");


                  // perimeter width
                  Console.WriteLine("Perimeter  = width: \n");

                  double widthPerimeter = double.Parse(Console.ReadLine());

                  Console.WriteLine("\n");

                  double totalPerimeter = (length + width) * 2;


                  Console.WriteLine("\n");


                  Console.WriteLine("The total Perimeter  is " + totalPerimeter);

                  Console.WriteLine("\n");



                  // continue yes or no

                  Console.WriteLine("Do you want to continue calculating?  Yes or No.");
                     
                    restarting = Console.ReadLine();

                     

                
                  Console.ReadLine();

                


            } 

                



        }



        
    }
}
