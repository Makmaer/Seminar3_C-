void Diapazon (int chetvert)
{
    if (chetvert == 1) Console.WriteLine("0 < x < + бесконечность; 0 < y < + бесконечность");
    if (chetvert == 2) Console.WriteLine("0 > x > - бесконечность; 0 < y < + бесконечность");
    if (chetvert == 3) Console.WriteLine("0 > x > - бесконечность; 0 > y > - бесконечность");
    if (chetvert == 4) Console.WriteLine("0 < x < + бесконечность; 0 > y > - бесконечность");
    else if (chetvert < 1 || chetvert > 4) Console.WriteLine("Такой четверти не существует"); 
}

Console.WriteLine("Введите номер четверти: ");
int chetvert  = Convert.ToInt32(Console.ReadLine());
Diapazon(chetvert);