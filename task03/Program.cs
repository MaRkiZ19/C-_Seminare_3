//

int Read(string coordinate)
{
    System.Console.WriteLine($"Введите {coordinate}:");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int x1 = Read("x1");
int y1 = Read("y1");
int x2 = Read("x2");
int y2 = Read("y2");

double Magic(int x1, int y1, int x2, int y2)
{
    /*double X = x2 - x1;
    double Y = y2 - y1;
    double C1 = (double)Math.Pow(X, 2) + (double)Math.Pow(Y, 2);
    double C = (double)Math.Sqrt(C1);
    return C;*/

    return Math.Round(Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)),3);
}

double C = Magic(x1, y1, x2, y2);
System.Console.WriteLine($"Дина отрезка - {C}");
