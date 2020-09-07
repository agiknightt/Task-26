using System;
using System.Collections.Generic;

namespace Task_26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            
            bool enterOrExit = true;

            while (enterOrExit)
            {
                InputAndSumNumbers(numbers, ref enterOrExit);
            }
        }

        private static void InputAndSumNumbers(List<int> numbers, ref bool enterOrExit)
        {
            int sum = 0;

            Console.WriteLine("Выберите нужный пункт меню\n\nadd - добавить число\n\nsum - вывести сумму введеных чисел\n\nexit - выход\n");

            switch (Console.ReadLine())
            {
                case "add":
                    Console.Write("Введите число : ");
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                    break;
                case "sum":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                    break;
                case "exit":
                    enterOrExit = false;
                    break;
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
