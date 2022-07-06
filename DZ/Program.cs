//ЗАДАЧА 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
void Polindrom ()
{
    double kol=0;
    double chis=0;
    
    for (int i = 10000; i < 100000; i++)
    {
      if (i/10000 == i % 10 && (i-((i/10000)*10000))/1000 == (i % 100)/10)
      {
        Console.WriteLine(i);
        kol=kol+1;
      } 
     
      chis=chis+1;
    }
    Console.WriteLine("Всего полиндромов среди пятизначных чисел = " + kol);
    Console.WriteLine("Всего чисел на выбраном интервале = " + chis);
    double rez= (kol/chis)*100;
    Console.WriteLine("Вероятность выпадения полиндрома при выводе пятизначного числа случайным образом равна " + rez + " процент");
}

void RandomPolindrom ()
{
    int rand = new Random().Next(10000, 100000);
    Console.WriteLine("Sluchaynoe chislo = " + rand);
    if (rand/10000 == rand % 10 && (rand-((rand/10000)*10000))/1000 == (rand % 100)/10)
      {
        Console.WriteLine("Число является полиндромом " );
      } 
      else {Console.WriteLine("Число не полиндром " );}
}
Polindrom();
RandomPolindrom ();*/

//ЗАДАЧА 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Koordinata (double x1, double y1, double z1, double x2, double y2, double z2)
{
double rezult = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
return rezult;
}
Console.WriteLine("Введите х1: ");
double x1  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
double y1  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1: ");
double z1  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите х2: ");
double x2  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
double y2  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2: ");
double z2  = Convert.ToInt32(Console.ReadLine());
double rez = Koordinata(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Расстояние между точками= " + rez);

//ЗАДАЧА 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void KubChisel (int N)
{for (int i = 1; i <= N; i++)
    {
    Console.Write(" " + i + " ");
    Console.WriteLine(" " + i*i*i + " ");
    }
}

Console.WriteLine("Введите ччисло ");
int n  = Convert.ToInt32(Console.ReadLine());
KubChisel(n);*/



