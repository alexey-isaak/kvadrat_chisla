using System;
 
namespace kvadrat_chisla
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число: ");
            int chislo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int chislo2 = int.Parse(Console.ReadLine());
            if ( chislo1 == chislo2 * chislo2 )
            {
                Console.WriteLine(chislo1 + " является квадратом числа " + chislo2);
            }
            else
            {
                Console.WriteLine(chislo1 + " НЕ является квадратом числа " + chislo2);
            }
        }
    }
}
