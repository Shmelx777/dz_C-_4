// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber(string str)
{
    int number;
    string text;
    while(true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if(int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не корректное число, попробуйте еще раз");
    }
    return number;
}

int A = InputNumber("Введите число: ");
int sum = 0;

while (A > 0)
{
int num = A % 10;
A = A / 10;
sum = sum + num;
}
Console.WriteLine(sum);