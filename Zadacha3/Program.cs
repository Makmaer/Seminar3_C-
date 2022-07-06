void KvadratChisel (int N)
{for (int i = 1; i <= N; i++)
    {
    Console.Write(" " + i + " ");
    Console.WriteLine(" " + i*i + " ");
    }
}

Console.WriteLine("Введите ччисло ");
int n  = Convert.ToInt32(Console.ReadLine());
KvadratChisel(n);