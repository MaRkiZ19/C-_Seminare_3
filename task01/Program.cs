/*Напишите программу, которая принимает на вход координаты точки (X и Y),
 причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/

int Read(string coordinate)
{
    System.Console.WriteLine($"Введите {coordinate}:");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int x = Read("x");
int y = Read("y");

int QouteNumb(int x, int y)
{
    if (x>0 && y>0) return 1;
    else if (x>0 && y<0) return 4;
    else if (x<0 && y>0) return 2;
    else return 3;
}

if (x==0 || y==0) System.Console.WriteLine("точка лежит на оси");
System.Console.WriteLine($"Точная с координатами {x}{y} находится в четверти  - {QouteNumb(x,y)}");

