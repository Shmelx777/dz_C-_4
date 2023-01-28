// Задача 30: Напишите программу, которая выводит 
// массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] array = FillArrayWithRandomNumbers(8, 0, 50);



PrintArray(array);