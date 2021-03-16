using System;

namespace Lab2RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Welcome to Grand Circus Room Detail Generator\n");
            bool cont = true;

            while (cont)

            {
                Console.Write("Enter Length:");
                double length = Double.Parse(Console.ReadLine());
                Console.Write("Enter Width:");
                double width = Double.Parse(Console.ReadLine());
                Console.Write("Enter Height:");
                double height = Double.Parse(Console.ReadLine());

                double area = length * width;
                double perimeter = (2 * length) + (2 * width);
                double volume = length * height * width;

                Console.WriteLine($"The area is {area}");
                Console.WriteLine($"The perimeter is {perimeter}");
                Console.WriteLine($"The volume is {volume}");

                if (area <= 250)
                {

                    Console.WriteLine(" This is a small size room");
                }
                else if (area > 250 && area < 650)
                {

                    Console.WriteLine(" This is a medium-sized room");
                }
                else
                {

                    Console.WriteLine("This is Large size room");
                }


                Console.WriteLine("would you want to continue? Yes or No");
                string userLoopInput = Console.ReadLine();

                //you can also use .Equals as well 

                if(userLoopInput.StartsWith("no", StringComparison.OrdinalIgnoreCase))
                {
                    cont = false;
                    Console.WriteLine("Thank you for using the Room Detail Generator");
                }
               

            }

               
            

        }
    }
}
