using Tyuiu.VlasenkoAE.Sprint2.Task2.V23.Lib;

Console.Title = "Спринт #2 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #23                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
Console.WriteLine("* области.                                                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
int y = Convert.ToInt32(Console.ReadLine());

DataService ds = new DataService();
bool res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

if (res)
{
    Console.WriteLine("Точка находится в заштрихованной области");
}
else
{
    Console.WriteLine("Точка не находится в заштрихованной области");
}

Console.ReadKey();