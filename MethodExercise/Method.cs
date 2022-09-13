using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    internal class Method

    {
        public static void Exercise1()
        {

            Console.WriteLine("What is your first name?");
            var firstName = Console.ReadLine(); //input from user

            Console.WriteLine("What is your favorite color?");
            var favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            int favoriteNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hi {firstName}!  My favorite color is also {favoriteColor}.  " +
            $"I love that your favorite animal is a {favoriteAnimal}.  I also just learned " +
            $"that your favorite number is {favoriteNumber}.");
        }



        //Declare 5 methods: 1 Add method, 1 subtract method, 1 multiply method, 1 divide method, 1 modulus method.

        //add method
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        //subtract method
        public static int Subtract(int num1, int num2, int num3)
        {
            return num1 - num2 - num3;
        }

        //multiply method
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        //divide method
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        //modulus method
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        //Step 8 Bonus: Change the functions to use the params keyword to support a range of arguements.

        public static int AddParams(params int[] parameterArrayNumbers)
        {
            int totalAdd = 0;
            
            foreach (int num in parameterArrayNumbers)
            {
                totalAdd += num;
            }

                return totalAdd; 

               
        }
        

            
    }
}
