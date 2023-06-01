// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int InputNumber (string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int[] InputArray (int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = InputNumber ($"Введите {i + 1} элемент");
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i ++)
//     {
//         Console.WriteLine($"a[{i}] = {array[i]}");
//     }
// }

// int PosNumber(int [] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i ++)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// int length = InputNumber ("Укажите количество элементов");
// int[] array;
// array = InputArray(length);
// PrintArray(array);
// Console.WriteLine($"Количество чисел больше 0 -> {PosNumber(array)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
const int Coeff = 0;
const int Const = 1;
const int X = 0;
const int Y = 1;
const int L1 = 1;
const int L2 = 2;

double[] LineData1 = InputLineData(L1);
double[] LineData2 = InputLineData(L2);

if (ValidateLines(LineData1, LineData2))
{
    double[] coord = FindCoords (LineData1, LineData2);
    Console.Write($"Точка пересечения y= {LineData1[Coeff]}*X+{LineData1[Const]} и y= {LineData2[Coeff]}*X+{LineData2[Const]}");
    Console.WriteLine($"имеет координаты ({coord[X]}{coord[Y]})");
}
double Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberofline)
{
    double[] LineData = new double[2];
    LineData[Coeff] = Prompt($"Введите коэффициэнт {numberofline} прямой >");
    LineData[Const] = Prompt($"Введите константу для {numberofline} прямой >");
    return LineData;
}
double[] FindCoords(double[] LineData1, double[] LineData2)
{
    double[] coord = new double[2];
    coord[X] = (LineData1[Const] - LineData2[Const]) - (LineData2[Coeff] - LineData1[Coeff]);
    coord[Y] = LineData1[Const] * coord[X] + LineData1[Const];
    return coord;
}
bool ValidateLines(double[] LineData1, double[] LineData2)
{
    if (LineData1[Coeff] == LineData2[Coeff])
    {
        if (LineData1[Const] == LineData2[Const])
        {
            Console.WriteLine("Прямые совпадения");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельные");
            return false; 
        }
    }
    return true;
}