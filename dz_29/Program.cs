// Задача 30: Напишите программу, которая выводит 
// массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


int[] randnumber = new int[8];
for(int i = 0; i < randnumber.Length;i++)
{
    Random rand = new Random();
    randnumber[i] = rand.Next(0,50);
}

void Viewnumber (int[] number)
{
    System.Console.Write($"[{string.Join(", ",number)}]");
}

Viewnumber(randnumber);