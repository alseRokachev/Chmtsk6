// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int textCheck(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Некорректное число");
    }
    return number;
}

double[] numbsArray()
{
    double[] array = new double[4];
    for (int i = 0; i < 2; i++)
    {
        array[i] = Convert.ToDouble(textCheck($"Введите B{i + 1}: "));
        array[i + 2] = Convert.ToDouble(textCheck($"Введите K{i + 1}: "));

    }
    return array;
}

double crossPointFounderY(double[] array)
{
    double answerY = Math.Round(array[2] * (array[1] - array[0]) / (array[2] - array[3]) + array[0], 3);
    return answerY;
}

double crossPointFounderX(double[] array)
{
    double answerX = Math.Round((array[1] - array[0]) / (array[2] - array[3]), 3);
    return answerX;
}

double[] array = numbsArray();
double pointX = crossPointFounderX(array);
double pointY = crossPointFounderY(array);
System.Console.WriteLine($"Точка пересечения: ( {pointX} ; {pointY} )");