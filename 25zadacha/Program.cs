// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// 2 решение
Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую хотите возвести: ");
int B = Convert.ToInt32(Console.ReadLine());
int numbA = A;
for (int i = 1; i < B; i++)
{
    A = numbA * A;
}
Console.WriteLine($"{numbA} в {B} степени равно: {A}");

// 1 решение
// Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень, в которую хотите возвести: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int result = Convert.ToInt32(Math.Pow(A, B));
// Console.WriteLine(result);
