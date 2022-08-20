// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

// Console.Write("Enter NumberA ");
// int NumberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter NumberB ");
// int NumberB = Convert.ToInt32(Console.ReadLine());

// if(NumberA > NumberB)
// {
//     int MaxNumber = NumberA;
//     Console.Write("max = ");
//     Console.WriteLine(NumberA);
// }
// else
// {
//     Console.Write("max = ");
//     Console.WriteLine(NumberB);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Enter NumberA ");
// int NumberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter NumberB ");
// int NumberB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter NumberC ");
// int NumberC = Convert.ToInt32(Console.ReadLine());
// int max = NumberA;

// if(NumberA > NumberB && NumberA> NumberC)
//     {
//     Console.Write("max = ");
//     Console.WriteLine(NumberA);
//     }
// else
//     if(NumberB > NumberC && NumberB > NumberA)
//     {Console.Write("max = ");
//     Console.WriteLine(NumberB);
//     }
// else
//     if(NumberC > NumberB && NumberC > NumberA)
//     {Console.Write("max = ");
//     Console.WriteLine(NumberC);
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Enter Number ");
// int Number = Convert.ToInt32(Console.ReadLine());

// if(Number % 2 == 0)
// {
// Console.Write(Number);
// Console.Write(" Является четным числом");
// }
// else
// {
// Console.Write(Number);
// Console.WriteLine(" Является нечетным числом");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter Number ");
int Number = Convert.ToInt32(Console.ReadLine());
int i = 2;
    if(Number >= 2)
    {
        Console.Write("четные числа -> ");
        while(i <= Number)
        {
            if(i < Number && i != Number - 1)
            {
                Console.Write(i+", ");
            }
            else if(i == Number - 1 || i == Number)
            {
                Console.WriteLine(i+".");
            }
            i+= 2;
        }
    }
else
{
    Console.WriteLine("Четных чисел нету в этом диапозоне");
}