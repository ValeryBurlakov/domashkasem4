// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(10, 99);
// }
// Console.Write('[' + string.Join(", ", array) + "]");

Console.WriteLine("Введите длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 99);
}
Console.Write('[' + string.Join(", ", array) + "]");
