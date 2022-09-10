//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
System.Console.WriteLine("Введите Х координату первой точки: ");
int x1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Y координату первой точки: ");
int y1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Z координату первой точки: ");
int z1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите Х координату второй точки: ");
int x2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Y координату второй точки: ");
int y2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите Z координату второй точки: ");
int z2 = int.Parse(Console.ReadLine());

Double Coor = Math.Sqrt(Math.Pow (x2 - x1,2)+
                        Math.Pow (y2 - y1,2)+
                        Math.Pow (z2 - z1,2));

System.Console.WriteLine($"Coor ={Coor}");