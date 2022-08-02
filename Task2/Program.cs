/*Напишите программу, которая принимает на вход число N и выводит все простые числа в промежутке от 0 до N (включительно). 
После, попробуйте поэксперментировать с величиной значения N и понаблюдать за тем, как оно влияет на время выполнения программы.*/

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (num >= 10000 && num <= 99999)
{
    int a = num / 10000;
    int b = num % 10;
    int c = (num / 1000) % 10;
    int d = (num % 100) / 10;
    if (a == b & c == d)
        Console.WriteLine("Число " + Polindrom(num));

    else
    {
        Console.WriteLine(" Число не я вляется полиндромом");
    }
}
else
{
    Console.WriteLine(" Error ");
}
string Polindrom(int x)
{
    if (x / 10000 == x % 10 & (x / 1000) % 10 == (x % 100) / 10)
    {
        return "является полиндроном";

    }
    return "является полиндроном";
}


