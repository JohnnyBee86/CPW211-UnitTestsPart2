using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        /// <summary>
        /// Performs addition
        /// </summary>
        /// <param name="a">The first number in the equation</param>
        /// <param name="b">The second number to be added onto the first</param>
        /// <returns>The sum of the two numbers</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Performs subtraction
        /// </summary>
        /// <param name="a">The first number in the equation</param>
        /// <param name="b">The number to be subtracted from the first</param>
        /// <returns>The difference of the two numbers</returns>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Performs multiplication
        /// </summary>
        /// <param name="a">The first number in the equation</param>
        /// <param name="b">The number of times the first is multiplied</param>
        /// <returns>The product of the two numbers</returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Performs division
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="b">The denominator</param>
        /// <returns>The quotient of the two numbers</returns>
        /// <exception cref="ArgumentException">Thrown if the denominator entered is 0</exception>
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Denominator cannot be zero");
            }
            return a / b;
        }
    }
}
