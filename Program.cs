using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        private static void numberOfCarryOperations(int firstNumber, int secondNumber)
        {

            var firstNoArray = firstNumber.ToString().ToCharArray();
            var secondNoArray = secondNumber.ToString().ToCharArray();
            int i = 0;
            Stack<int> firstNo = new Stack<int>();
            while (i < firstNoArray.Length)
            {
                firstNo.Push(int.Parse(firstNoArray[i].ToString()));
                i++;
            }
            i = 0;
            Stack<int> secondNo = new Stack<int>();
            while (i < secondNoArray.Length)
            {
                secondNo.Push(int.Parse(secondNoArray[i].ToString()));
                i++;
            }
            int remaining = 0;
            int noOfCarries = 0;
            while (firstNo.Count > 0 || secondNo.Count > 0)
            {
                int f = firstNo.Count > 0 ? firstNo.Pop() : 0;
                int s = secondNo.Count > 0 ? secondNo.Pop() : 0;
                int sum = f + s + remaining;
                if(sum >=10)
                {
                    remaining = 1;
                    noOfCarries++;
                }
                else
                {
                    remaining = 0;
                }
            }

            Console.WriteLine(noOfCarries);
        }
        static void Main(string[] args)
        {
            numberOfCarryOperations(123, 456); // 0
            numberOfCarryOperations(555, 555); // 3
            numberOfCarryOperations(900, 11); // 0
            numberOfCarryOperations(145, 55); // 2
            numberOfCarryOperations(0, 0); // 0
            numberOfCarryOperations(1, 99999); // 5
            numberOfCarryOperations(999045, 1055); // 5
            numberOfCarryOperations(101, 809); // 1
            numberOfCarryOperations(189, 209); // 1
            Console.ReadLine();
        }
    }
}
