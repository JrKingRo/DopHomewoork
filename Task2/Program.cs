
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
        Console.WriteLine(" Число не является полиндромом");
    }
}
else
{
    Console.WriteLine(" Error ");
}
string Polindrom(int i)
{
    if (i / 10000 == i % 10 & (i / 1000) % 10 == (i % 100) / 10)
    {
        return "является полиндроном";

    }
    return "является полиндроном";
}


