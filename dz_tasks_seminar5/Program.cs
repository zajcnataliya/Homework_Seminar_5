
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void Zadacha34()
{
    Console.WriteLine("Задача 34");
    int size = 4;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 999);
    PrintArray(numbers);
    Console.WriteLine("Количество четных элементов: " + GetCountNumber(numbers));
    Console.WriteLine();
}

int GetCountNumber(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
            count++;
    }
    return count;
}

void FillArray(int[] numbers, int minValue = 0, int maxValue = 1000)  
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue); 
    }
}

void PrintArray(int[] numbers)  
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void Zadacha36()
{
    Console.WriteLine("Задача 36");
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 20);
    PrintArray(numbers);
    Console.WriteLine("Сумма элементов на нечетных позициях: " + GetSumNumber(numbers));
    Console.WriteLine();
}

int GetSumNumber(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
         if (i % 2 == 1)
             sum = sum + numbers[i];
    }
    return sum;

    // int sum = 0;
    // for (int i = 1; i < numbers.Length; i += 2)
    // {
    //     sum = sum + numbers[i];
    // }
    // return sum;
}
            


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76
void Zadacha38()
{
    Console.WriteLine("Задача 38");
    int size = 6;
    double[] numbers = new double[size];
    FillArrayDouble(numbers, 10, 100);
    PrintArrayDouble(numbers);
   
    
    var min = numbers[0];
    var max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
        else if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
        Console.WriteLine("max:  " + max);
        Console.WriteLine("min  " + min);
        Console.WriteLine("Разница максимального и минимального:  "+ (max - min));
}


void FillArrayDouble(double[] numbers, int minValue = 0, int maxValue = 9)  
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        double value = random.NextDouble() * 20 - 10;
        numbers[i] = Math.Round(value, 2); 
    }
}

void PrintArrayDouble(double[] numbers)  
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}




Zadacha34();
Zadacha36();
Zadacha38();