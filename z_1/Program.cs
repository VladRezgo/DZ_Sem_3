// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int secondnum()
{

int second = num%100/10;

Console.Write(num+("->" + "второе число "));

    return second;
};
Console.WriteLine (secondnum());
