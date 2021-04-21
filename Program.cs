using System;

namespace week2Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("WELCOME TO SARAH'S PIZZA STORE!");
            // Console.WriteLine("Small  is 500");
            // Console.WriteLine("Medium is 1000");
            // Console.WriteLine("Large  is 1500");
            // Console.WriteLine("Please Select 1,2,3 for small ,medium and large Respectively");
            // var small = 500;
            // var medium = 1000;
            // var large = 1500;
            // var input = Convert.ToInt32(Console.ReadLine());
            
            // if (input>3)
            // {
            //    Console.WriteLine("we only have small,medium and large") ;
            // }
            
            // else if(input ==1)
            // {
            //     Console.WriteLine("Thank you for shopping with us your bill is " +small) ; 
            // }
            // else if(input ==2)
            // {
            //       Console.WriteLine("Thank you for shopping with us your bill is " +medium) ; 
            // }
            // else if (input == 3)
            // {
            //       Console.WriteLine("Thank you for shopping with us your bill is " + large) ; 
            // }
          
            Console.WriteLine("WELCOME TO SARAH'S PIZZA STORE!");
            Console.WriteLine("Small  is 500");
            Console.WriteLine("Medium is 1000");
            Console.WriteLine("Large  is 1500");
            Console.WriteLine("Please Select 1,2,3 for small ,medium and large Respectively");
            var small = 500;
            var medium = 1000;
            var large = 1500;
            var input = Convert.ToInt32(Console.ReadLine());
           
           while (input <1 || input > 3)
           {
                Console.WriteLine("we only have 1, 2, 3 which is small, medium and large please enter 1, 2 or 3") ; 
               input = Convert.ToInt32(Console.ReadLine());
           }

         
            switch (input)
            {
                case 1:
                Console.WriteLine("Thank you for shopping with us your bill is " +small) ;
                    break;
                    case 2:
                   Console.WriteLine("Thank you for shopping with us your bill is " +medium) ;
                     break;
                     case 3:
                  Console.WriteLine("Thank you for shopping with us your bill is " +large) ;
                      break;
                      default:
                       Console.WriteLine(" we dont have more than 3 ");
                      break;
            }
            
           
        }
    }
}
