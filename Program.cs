using System;

namespace HW_Mod_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int num = int.Parse(Console.ReadLine());
            if (num%2 == 0)
            {
                Console.WriteLine("Введенное Вами число является чётным.");
            }
            else
            {
                Console.WriteLine("Введенное Вами число является нечётным.");
            }
            Console.ReadLine();
        }
    }
}
