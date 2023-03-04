// Напишите программу которая по заданному номеру четверти
// показывает диапазон возможных координат точек в этой четверти (X и Y).

Console.Clear();
Console.Write("Введите номер четверти координатной плоскости: ");
int quater = int.Parse (Console.ReadLine());

switch(quater)
{
case 1:{
    Console.Write($"В {quater} четверти расположены значения для X>0 и Y>0");
    break;
    }
case 2:{
    Console.Write($"В {quater} четверти расположены значения для X<0 и Y>0");
    break;
    }
case 3:{
    Console.Write($"В {quater} четверти расположены значения для X<0 и Y<0");
    break;
    }
case 4:{
    Console.Write($"В {quater} четверти расположены значения для X>0 и Y<0");
    break;
    }
default:{
Console.Write($" {quater} - число не соответтвует возможным номерам четверти");
break;
}
}
