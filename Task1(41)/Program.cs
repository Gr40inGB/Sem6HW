// // Задача 41: Пользователь вводит с клавиатуры M чисел.
// // Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3
using System.Text;

void Root()
{
    Console.Clear();
    System.Console.Write("Программа подсчитает количество всех положительных введенных в строке чисел.\nВведите строку: ");
    string inputString = Console.ReadLine()!;
    string simpleString = ReturnSimpleString(inputString!);
    System.Console.WriteLine($"В Вашей строке обнаружены следующие числа: {simpleString}");
    System.Console.WriteLine($"Положительных чисел в ней: {SearchUpperZero(simpleString)} шт");
}

int SearchUpperZero(string stringForSearch)
{
    int countNatural = 0;
    string[] numbers = stringForSearch.Split(",");
    for (int i = 0; i < numbers.Length; i++)
    {
        if (Convert.ToInt32(numbers[i]) > 0)
            countNatural++;
    }
    return countNatural;
}



string ReturnSimpleString(string inString)
{
    StringBuilder snake = new StringBuilder(32);
    string maybeInt = null;  // строка в которой мы будем накапливать последовательные цифры  или + - перед числом

    for (int i = 0; i < inString.Length; i++)
    {
        if (inString[i] == '-') // если встречаем минус 
        {
            if (maybeInt != null && maybeInt != "-")       // если до этого maybeInt что-то содержало - то там явно было число и его можно выводить
            {
                snake.Append(maybeInt + ", ");
                maybeInt = "-";        // зануляем для поиска дальше
            }
            else maybeInt = "-";                 // если в maybeInt не было ничего добавляем минус
        }
        else if (Char.IsNumber(inString[i]))
        {
            maybeInt += inString[i];
            if ((i == inString.Length - 1))
            {
                snake.Append(maybeInt);
            }
        }
        else
        {
            if (maybeInt != null && maybeInt != "-")       // если до этого maybeInt что-то содержало - то там явно было число и его можно выводить
            {
                snake.Append(maybeInt + ", ");
                maybeInt = null;        // зануляем для поиска дальше
            }
            else if (maybeInt != null)                      // если до этого был минус - зануляем строку
            {
                maybeInt = null; // зануляем для поиска дальше
            }
        }
    }
    return snake.ToString();
}

Root();

