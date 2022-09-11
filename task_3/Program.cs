// ## задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

bool CheckTriangle(double a, double b, double c)
{
    bool check = false;
    if (a<b+c | b<a+c | c<a+b)
    {
        check = true;
    }
    return check;
}

double PerimetrTriangle(double a, double b, double c)
{
    double P = 0;
    P = a+b+c;
    return P;
}

double SquareTriangle(double a, double b, double c)
{
    double S = 0;
    double p = PerimetrTriangle(a, b, c)/2;
    S = Math.Round(Math.Sqrt(p*(p-a)*(p-b)*(p-c)), 2);
    return S;
}

double AngleAB(double a, double b, double c)
{
    double angleAB = 0;
    angleAB = Math.Round(Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI, 2);
    return angleAB;
}

double AngleBC(double a, double b, double c)
{
    double angleBC = 0;
    angleBC = Math.Round(Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI, 2);
    return angleBC;
}

double AngleCA(double a, double b, double c)
{
    double angleCA = 0;
    angleCA = Math.Round(Math.Acos((c * c + a * a - b * b) / (2 * c * a)) * 180 / Math.PI, 2);
    return angleCA;
}

Console.Write("Введите длину стороны a: \t");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны b: \t");
double b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны c: \t");
double c = Convert.ToInt32(Console.ReadLine());

if (CheckTriangle(a, b, c) == true)
{
    Console.WriteLine($"Периметр треугольника равен: \t" + PerimetrTriangle(a, b, c));
    Console.WriteLine($"Площадь треугольника равна: \t" + SquareTriangle(a, b, c));
    Console.WriteLine($"Угол между сторонами a({a}) и b({b}) = " + AngleAB(a, b, c) + " градусов");
    Console.WriteLine($"Угол между сторонами b({b}) и c({c}) = " + AngleBC(a, b, c) + " градусов");
    Console.WriteLine($"Угол между сторонами c({c}) и a({a}) = " + AngleCA(a, b, c) + " градусов");
    if (AngleAB(a, b, c) == 90 | AngleBC(a, b, c) == 90 | AngleCA(a, b, c) == 90) Console.WriteLine("Треугольник прямоугольный");
    if (a == b | b == c | c == a) Console.WriteLine("Треугольник равнобедренный");
    if (a == b & a == c) Console.WriteLine("Треугольник равносторонний");
}
else Console.WriteLine("Это НЕ треугольник");
