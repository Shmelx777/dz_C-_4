// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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

int A = InputNumber("Введите число A: ");
int B = InputNumber("Введите число B: ");
int num = A;

for (int i = 1; i < B; i++)
{
num = num * A;
}
System.Console.WriteLine(num);