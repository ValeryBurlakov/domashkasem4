Console.WriteLine("Введите номер задачи(25, 27 или 29): ");
int numbzad = Convert.ToInt32(Console.ReadLine());
if (numbzad == 25 || numbzad == 27 || numbzad == 29)
{
if (numbzad == 25)
{
Console.WriteLine("Введите число, которое хотите возвести в степень: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую хотите возвести: ");
int B = Convert.ToInt32(Console.ReadLine());
int numbA = A;
for (int i = 1; i < B; i++)
{
    A = numbA * A;
}
Console.WriteLine($"{numbA} в {B} степени равно: {A}");
}
if (numbzad == 27)
{
Console.WriteLine("Введите число, а мы покажем сумму его цифр:");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 0;
for (int i = 0; number > 0; i++)
{
    number1 = (number % 10) + number1;
    number = number / 10;
}
Console.WriteLine($"Сумма цифр в числе равна: {number1}");
}

if (numbzad == 29)
{
  void FillArray(int[] collection)// рандомный метод
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(-99, 99); // рандомные элементы массива
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)// ищет минимального элемента
    {
        if (array[j] < array[minPosition]) 
        {
            minPosition = j;
        }
    }
        int temporary = array[i]; // производится замена элемента
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }

}

void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
    for (int j = i + 1; j < array.Length; j++)// ищет максимальный элемента
    {
        if (array[j] > array[maxPosition]) 
        {
            maxPosition = j;
        }
    }
        int temporary = array[i]; // производится замена элемента
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }

}
// для ввода с клавиатуры закоменти 2 строчки ниже
int t = new Random().Next(2, 20); // Создали рандомное количество элементов массива
int[] array = new int[t];// вместо t можно определить самому количество элементов в массиве

FillArray(array);//метод, который заполнил массив
Console.Write("ваш рандомнозаполненый рандомный массив: ");
PrintArray(array);
SelectionSortMin(array);
Console.Write("ваш отсортированный массив от меньшего к большему: ");
PrintArray(array);
SelectionSortMax(array);
Console.Write("ваш отсортированный массив от большего к меньшему: ");
PrintArray(array);
  
}
}
else
{
    Console.WriteLine("вы ввели неправильно номер задачи, у нас есть только 25, 27 и 29, повторите попытку");
}