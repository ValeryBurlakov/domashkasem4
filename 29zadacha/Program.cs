// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// 1. Решение, без усложнений по условию задачи

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(10, 99);
// }
// Console.Write('[' + string.Join(", ", array) + "]");

// 2. Решение. Длина массива вводится пользователем

// Console.WriteLine("Введите длину массива: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[number];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-99, 99);
// }
// Console.Write('[' + string.Join(", ", array) + "]");


// 3. Решение. Ввод  длины массива и каждого его элемента вручную (либо всё рандомно) 
// и последующая его сортировка. Не знаю как ещё можно усложнить себе задачу:

Console.WriteLine("Введите длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

for (int i = 0; i < array.Length; i++)
{
    int index = i + 1;
    Console.Write($"Введите {index} элемент массива с индексом {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
// Console.Write('[' + string.Join(", ", array) + "]");
Console.WriteLine();

// рандомное количество элементов массива и рандомные элементы в нём, 
// для ручного ввода раскоментить 29-40 и 109. Закоментить 45-54 и 104-108 и 111 строчки и наоборот

// void FillArray(int[] collection)// рандомный метод
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(-99, 99); // рандомные элементы массива
//         index++;
//     }
// }

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
// для ввода с клавиатуры закоменти 104-108  строчки ниже
// int t = new Random().Next(2, 20); // Создали рандомное количество элементов массива
// int[] array = new int[t];// вместо t можно определить самому количество элементов в массиве

// FillArray(array);//метод, который заполнил массив
// Console.Write("ваш рандомнозаполненый рандомный массив: ");
Console.Write("ваш массив: ");
PrintArray(array);
// Console.WriteLine($"Количество элементов в вашем массиве равно: {array.Length}");
SelectionSortMin(array);
Console.Write("ваш отсортированный массив от меньшего к большему: ");
PrintArray(array);

SelectionSortMax(array);
Console.Write("ваш отсортированный массив от большего к меньшему: ");
PrintArray(array);



