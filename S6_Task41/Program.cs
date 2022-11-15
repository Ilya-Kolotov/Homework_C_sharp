// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
   
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
   
}

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число №{i + 1}:  ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
int GetCountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
int countPositiveNumbers = GetCountPositiveNumbers(array);
PrintArray(array);
Console.WriteLine($" -> Количество чисел больше 0 = {countPositiveNumbers}");