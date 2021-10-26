using System;

namespace _27._10._21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(sumMult(5,9));      //1
            //Console.WriteLine(sumOfAll(5, 9));    //2
            //Console.WriteLine("Sum of two numbers is "+sumOfTwo(2,3));        //3
            //calc();       //4
        }

        #region task1
        public static string sumMult(int a, int b) {

            string sm = $"Sum of the two params is {a+b} and multiplication of them is {a*b}";
           
            return sm;
        }
        #endregion

        #region task2
        public static int sumOfAll(int a, int b) {
            if (a<b)
            {
                int sum = 0;
                for (int i = a; i <= b; i++) {
                    sum = sum + i;

                }

            return sum;
            }
            return 0;
            
        }
        #endregion

        #region task3
        public static int sumOfTwo(int a, int b) {
            return a + b;
        }
        #endregion

        #region task4
        public static void calc() {
            double result = 0;
            Console.WriteLine("***** C A L C U L A T O R *****");

            Console.Write("Enter the number: ");
            double firstNum = firstNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation(+, -, *, /, %): ");
            string op = Console.ReadLine();

            
            do
            {
                Console.Write("Enter the sec number: ");
                double secNum = secNum = Convert.ToDouble(Console.ReadLine());

                if (op.Equals("+"))
                {
                    result = firstNum + secNum;
                }
                else if (op.Equals("-"))
                {
                    result = firstNum - secNum;
                }
                else if (op.Equals("*"))
                {
                    result = firstNum * secNum;
                }
                else if (op.Equals("/"))
                {
                    result = firstNum / secNum;
                }

                else if (op.Equals("%"))
                {
                    result = firstNum % secNum;
                }
                else
                {
                    Console.WriteLine("Please enter the valid symbol!");
                }

                Console.WriteLine(result);
                Console.Write("Enter the operation or exit(+, -, *, /, %, \"exit\"): ");
                op = Console.ReadLine();
                if (op.Equals("exit"))
                {
                    break;
                }
                firstNum = result;

            } while (true);

        }
        #endregion
    }
}
