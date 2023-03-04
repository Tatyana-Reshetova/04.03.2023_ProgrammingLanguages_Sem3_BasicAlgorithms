// Напишите программу котора принимает на вход число N
// и выдает таблицу квадратов чисел от 1 до N либо от N до 1 в случае, если N отрицательное
// 5 -> 1,4,9,16,25
// 2 -> 1,4
// -2 -> 4,1 

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int m = N; //m = -10
if (N < 0)
{
    i = N; // i = - 10
    m = - N; // m = 10
    N = - 1; // N = -1
}
int[] result = new int [m];
int j = 0;
for (; i<=N; i++)
{
    result[j] = i*i;
    j++;
}  
for (j = 0; j < m ; j++)
    Console.Write($"{result[j]} ");

