using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //var answer = 4;
            //if (answer < 9)
            //{
            //    Console.WriteLine($"{answer} is less than 9");
            //}
            //else
            //{
            //    Console.WriteLine($"{answer} is greater than or equal to 9");
            //}



            var answer = 4;
            

           var response = (answer < 9) ? "{answer} is  less than nine" : "{answer} is equal to or greater than 9";
            Console.WriteLine( response);
           

                Console.WriteLine("Hello World!");
        }
    }
}
