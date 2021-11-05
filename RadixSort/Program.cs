using System;
using System.Collections.Generic;
using System.Text;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // queue number
            Queue<int> number = new Queue<int>();

            Queue<int> [] tempNumber = new Queue<int>[10];
            Console.WriteLine("HELP: ");
            Console.WriteLine("╚► Press 'E' For Exit From Gibing Number!!");
            Console.WriteLine("╚► You can only enter numbers with a maximum of two digits!! Like 24, 36");
            Console.WriteLine(Environment.NewLine + "---------------------------------------" + Environment.NewLine);
            // in here give number from user
            while (true)
            {
                Console.Write("Enter Number : ");
                string input = Console.ReadLine();
                // For exit prees "E"
                if(input == "E") break;
                if (input.Length != 2)
                {
                    Console.WriteLine("You can only enter numbers with a maximum of two digits! Like 24, 36, 47 and other ... !! ");
                    continue;
                }
                int n = int.Parse(input);
                number.Enqueue(n);
            }
            int numbersLength = 2;
            int x = numbersLength - 1;
            int roundOf = 0;
           

            for (int i = 0; i < numbersLength; i++)
            {
                foreach (int numb in number)
                {
                    string index = numb.ToString();
                    int intVal = (int)Char.GetNumericValue(index[x]);

                    if (tempNumber[intVal] == null) tempNumber[intVal] = new Queue<int>();
                    tempNumber[intVal].Enqueue(numb);
                }
                number.Clear();
                
                foreach (Queue<int> qu in tempNumber)
                {
                    if (qu != null)
                    {
                        foreach (int nu in qu)
                        {
                            number.Enqueue(nu);
                        }
                    }
                }
                tempNumber = new Queue<int>[10];
                x--;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------ RADIX SORT ------------");
            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (int numb in number)
            {
                Console.WriteLine(numb.ToString());
            }


            Console.ReadKey();
        }

    }
}
