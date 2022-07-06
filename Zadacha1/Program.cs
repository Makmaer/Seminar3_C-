int OpredChetvert(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;

    return -1;

}

Console.WriteLine("input X coord: ");
int x =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input Y coord: ");
int y =Convert.ToInt32(Console.ReadLine());

int q = OpredChetvert(x, y);
if(q == -1) Console.WriteLine("Tochka nahoditsy na osyh" );
else Console.WriteLine("Chetvert = " + OpredChetvert(x, y));