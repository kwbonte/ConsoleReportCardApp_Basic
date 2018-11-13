using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReportCardApp_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy world");
            int x = GetInput("Enter Total Students: ");
        
            ConstructReportCardArray(x);
            Console.ReadKey();
        }

        public static void ConstructReportCardArray(int size)
        {
            int[,] studentInfo =new int[size, 5]; // {english, math, computer, total, position of name array}
            string[] studentName = new string[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter Student Name : ");
                studentName[i] = Console.ReadLine();
                studentInfo[i, 0] = GetInput("Enter English Marks (Out Of 100) : ");
                studentInfo[i, 1] = GetInput("Enter Math Marks (Out Of 100) : ");
                studentInfo[i, 2] = GetInput("Enter Computer Marks (Out Of 100) : ");
                studentInfo[i, 3] = studentInfo[i, 0] + studentInfo[i, 1] + studentInfo[i, 2];
                studentInfo[i, 4] = i;
                Console.WriteLine("***************************************************");
            }
            Console.WriteLine("****************Report Card*******************");
            Console.WriteLine("****************************************");
            for(int i =0; i < size; i++)
            {
                Console.Write("Student Name: {0}", studentName[studentInfo[i,4]]);
                int sum = 0;
                for(int j = 0; j< 3; j++)
                {
                    sum += studentInfo[i, j];
                }
                Console.Write(", Total: {0}/300", sum);
                Console.WriteLine();
            }
        }

        public static int GetInput(string prompt)
        {
            int inputNum;
            Console.Write(prompt);
            string inputVal = Console.ReadLine();
            if (Int32.TryParse(inputVal, out inputNum) && inputNum >-1 && inputNum < 101)
            {
                return inputNum;
            }
            Console.WriteLine("\nPlease enter a positive integer value between 0 and 100.");
            return GetInput(prompt);
        }
    }
}
