using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolving
{
    class CalculatorMadness
    {

        //public void AddTwoNUmbers()
        //{
        //    Console.WriteLine("Please enter the first number:");
        //    int numberOne = int.Parse(Console.ReadLine());

        //    Console.Write("Please enter the second Number:");
        //    int numberTwo = int.Parse(Console.ReadLine());

        //    int result = numberOne + numberTwo;
        //    Console.WriteLine("The result of this addition is " + result);

        //}


        public int AddTwoNUmbers(int value1, int value2) //passing in values 
        {
         
            int result = value1 + value2;
            return result;
        }


        public int RunCalculations() 
        {

            Console.WriteLine("Enter first number to add:");
            int value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number to add:");
            int value2 = int.Parse(Console.ReadLine());

            int output = AddTwoNUmbers(value1, value2);

            Console.WriteLine("The result is: " + output);

            return output;

        }

        public void SubtractTwoNumbers()  //subtract two numbers
        {

            Console.WriteLine("Enter first number to add:");
            int value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number to add:");
            int value2 = int.Parse(Console.ReadLine());

            int output = value1 - value2;
            Console.WriteLine("The result is: " + output);

        }

        public void MultiplyTwoNumbers() //Multiple two numbers
        {

            Console.WriteLine("Enter first number to add:");
            int value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number to add:");
            int value2 = int.Parse(Console.ReadLine());

            int output = value1 * value2;
            Console.WriteLine("The result is: " + output);

        }

        public void DivideTwoNumbers() //Divide two numbers
        {
            Console.WriteLine("Enter first number to add:");
            int value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number to add:");
            int value2 = int.Parse(Console.ReadLine());

            int output = value1 / value2;
            Console.WriteLine("The result is: " + output);

        }
    }
}
