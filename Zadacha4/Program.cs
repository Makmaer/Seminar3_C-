double Koordinata (double x1, double y1, double x2, double y2)
{
double rezult = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
return rezult;
}
Console.WriteLine("Введите х1: ");
double x1  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
double y1  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите х2: ");
double x2  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
double y2  = Convert.ToInt32(Console.ReadLine());
double rez = Koordinata(x1, y1, x2, y2);
Console.WriteLine("Расстояние между точками= " + rez);