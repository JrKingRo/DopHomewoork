/*Напишите программу для вычисления площади круга, прямоугольника и треугольника. 
Ввод данных осуществляется в диалоговом режиме.
На первом шаге у пользователя запрашивается фигура, площадь которой нужно вычислить. 
На втором шаге пользователь вводит параметры, необходимые для рассчета. 
Затем, выводится результат.*/

Console.WriteLine("Эта программа поможет найти площадь фигур : \n 1.Круг \n 2.Прямоугольник \n 3.Треугольник ");
Console.WriteLine("Выберите фигуру: ");
int figure = int.Parse(Console.ReadLine());

if (figure == 1)
{
    Console.WriteLine("Введите чему равен радиус круга : ");
    double radius = Convert.ToDouble(Console.ReadLine());
    double Pi = 3.14;
    double square = Pi * (radius * radius);

    Console.WriteLine(" Площадь круга равна : " + square);

}
else if (figure == 2)
{
    Console.WriteLine("Введите чему равна высота прямоугольникаа: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите чему равна длина прямоугольника: ");
    double b = Convert.ToDouble(Console.ReadLine());

    double square = a * b;
    Console.WriteLine("Площадь прямоугольника равна: " + square);
}
else if (figure == 3)
{
    Console.WriteLine(" Введите чему равна высота треугольника : ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(" Введите чему равно основание треугольника : ");
    double b = Convert.ToDouble(Console.ReadLine());

    double square = (a * b) / 2;
    Console.WriteLine("Площадь треугольник равна: " + square);
}
