// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// √(x2-x1)²+(y2-y1)²+(z2-z1)²


double inputInt ()
{
bool isNum = double.TryParse(Console.ReadLine(), out double num);
if (isNum)
{
    return num;
}
else
{
    Console.WriteLine("Вы ввели некорректные данные!");
    return -1;
}
}
Console.WriteLine("Введите координаты ax ");
double ax = inputInt();
Console.WriteLine("Введите координаты ay ");
double ay = inputInt();
Console.WriteLine("Введите координаты az ");
double az = inputInt();
Console.WriteLine("Введите координаты bx ");
double bx = inputInt();
Console.WriteLine("Введите координаты by ");
double by = inputInt();
Console.WriteLine("Введите координаты bz ");
double bz = inputInt();

double GetDistanseBetweenTwoPoints (double ax, double ay,double az,double bx,double by,double bz)
{
double ab = Math.Round (Math.Sqrt((Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)))); // Math.Round - округляет результат
return ab;
}

double result = GetDistanseBetweenTwoPoints (ax,ay,az,bx,by,bz);

Console.WriteLine(result);
