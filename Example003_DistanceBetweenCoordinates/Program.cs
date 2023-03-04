// Напишите программу
// которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2 D пространстве.

//A (3,6); B (2,1) - > 5,09
//A (7,-5); B (1,-1) - > 7,21
//sgrt((3-2)^2 + (6-1)^2) = 5.09
//double s = Math.Sqrt()

Console.Clear();
Console.Write("Введите координату точки x1: ");
Double x1 = Double.Parse(Console.ReadLine());
Console.Write("Введите координату точки y1: ");
Double y1 = Double.Parse(Console.ReadLine());
Console.Write("Введите координату точки x2: ");
Double x2 = Double.Parse(Console.ReadLine());
Console.Write("Введите координату точки y2: ");
Double y2 = Double.Parse(Console.ReadLine());
Double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2 , 2));
Console.WriteLine ($"d={d:f2}");