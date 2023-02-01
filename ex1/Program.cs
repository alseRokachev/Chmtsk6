// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



int textLimCheck(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            if (number > 0)
            {
                break;
            }
        }
        System.Console.WriteLine("Некорректное число");
    }
    return number;
}

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

int[] numbsArray(int lim)
{
    int[] array = new int[lim];
    for (int i = 0; i < lim; i++)
    {
        array[i] = textCheck($"Введите число {i + 1}: ");
    }
    return array;
}

int numbsCheck(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter += 1;
        }
    }
    return counter;
}

void printAnswer(int posNumbs, int[] array)
{
    if (posNumbs == 1)
    {
        System.Console.WriteLine($"Вы ввели {numbsCheck(array)} число больше 0");
    }
    else if (posNumbs >= 2 & posNumbs <= 4)
    {
        System.Console.WriteLine($"Вы ввели {numbsCheck(array)} числа больше 0");
    }
    else
    {
        System.Console.WriteLine($"Вы ввели {numbsCheck(array)} чисел больше 0");
    }
}

int lim = textLimCheck("Введите кол-во чисел: ");
int[] array = numbsArray(lim);
int posNumbs = numbsCheck(array);
printAnswer(posNumbs, array);