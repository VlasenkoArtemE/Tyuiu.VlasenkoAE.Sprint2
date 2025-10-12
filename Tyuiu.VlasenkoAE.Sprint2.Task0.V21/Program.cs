﻿using Tyuiu.VlasenkoAE.Sprint2.Task0.V21.Lib;

DataService ds = new DataService();

int x = 1705;
int y = 775;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.Title = "Спринт #2 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений и арифметических               *");
Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
Console.WriteLine("* (False, False, False, False, False, False), при x = 1705, y = 775.      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i=0; i<6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();