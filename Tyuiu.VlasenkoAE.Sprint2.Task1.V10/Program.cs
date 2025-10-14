using Tyuiu.VlasenkoAE.Sprint2.Task1.V10.Lib;

DataService ds = new DataService();

int a = 455;
int b = 335;
int c = 14;
int d = 17;

bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

Console.Title = "Спринт #2 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
Console.WriteLine("* а также арифметических выражений, которая вернет логическую             *");
Console.WriteLine("* последовательность(массив): (True, False, False, False, True, False),   *");
Console.WriteLine("* при a = 455, b = 335, c = 14, d = 17.                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();