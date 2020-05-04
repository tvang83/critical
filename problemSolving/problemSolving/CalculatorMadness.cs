using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSolving
{
    class CalculatorMadness
    {
        pulbic void AddTwoNUmbers()
        {
            Console.WriteLine("Please enter the first number:");
            int numberOne = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second Number:");
            int numberTwo = int.Parse(Console.ReadLine());

            int result = numberOne + numberTwo;
            Console.WriteLine("The result of this addition is " + result);

        }

        public void RunCalulations()
        {
            AddTwoNUmbers(5,7);
        }

    }
}
