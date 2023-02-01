// // Задача 41: Пользователь вводит с клавиатуры M чисел.
// // Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

void Root()
{
    //Console.Clear();
    System.Console.Write("Программа подсчитает количество всех положительных введенных в строке чисел.\nВведите строку: ");
    string inputString = Console.ReadLine();
    // string[] StringNumberArray = GetArrayFirst8Number(inputString);
    // PrintArray(StringNumberArray);
    CountNumbersInStr(inputString);
    // }
}



int CountNumbersInStr(string inString)
{
    int countPlusNumber = 0; // будет считать положительные числа
    int countAllNumber = 0;  // будет считать все числа
    string maybeInt = null;  // строка в которой мы будем накапливать последовательные цифры  или + - перед числом
    bool itsNumber = false;  //  тут будем выяснять находимся ли мы еще внутри числа в строке. Возмжно не пригодится

    for (int i = 0; i < inString.Length; i++)
    {
        if (inString[i] == '-') // если встречаем минус 
        {
            if (maybeInt != null && maybeInt != "-")       // если до этого maybeInt что-то содержало - то там явно было число и его можно выводить
            {
                System.Console.WriteLine(maybeInt);
                maybeInt = "-";        // зануляем для поиска дальше
            }
            else maybeInt = "-";                 // если в maybeInt не было ничего добавляем минус

        }
        else if (int.TryParse(maybeInt + inString[i], out int outNumber))
        {
            maybeInt += inString[i];
        }
        else
        {
            if (maybeInt != null || maybeInt != "-")       // если до этого maybeInt что-то содержало - то там явно было число и его можно выводить
            {
                System.Console.WriteLine(maybeInt);
                maybeInt = null;        // зануляем для поиска дальше
            }
        }
    }


    // for (int i = 0; i < inString.Length; i++)
    // {
    //     if (i == inString.Length - 1) // если строка закончилась - обработаем вручную
    //     {
    //         if (Char.IsNumber(inString[i]))  // если последний элемент число -
    //         {
    //             if (maybeInt != null)  /// если до этого не было ничего похожего на число или -/+
    //             {
    //                 maybeInt += inString[i];
    //                 System.Console.WriteLine(maybeInt);
    //             }
    //             else                    // если что-то было - то добавляем наш последний символ
    //             {
    //                 maybeInt += inString[i];
    //                 System.Console.WriteLine(maybeInt);
    //                 maybeInt = null;

    //             }
    //         }
    //         else
    //         {
    //             maybeInt += inString[i];
    //             System.Console.WriteLine(maybeInt);
    //             maybeInt = null;

    //         }
    //     }
    //     else if (Char.IsNumber(inString[i]))
    //     {
    //         maybeInt += inString[i];
    //     }
    //     else if (inString[i] == '-')     // если встречаем минус -  
    //     {
    //         if (maybeInt != null) System.Console.WriteLine(maybeInt);    // проверяем было ли число до этого - если да - то выводим его 
    //         {
    //             if (Char.IsNumber(inString[i + 1])) maybeInt += inString[i]; //то проверяем если ли после него цифра - ели да
    //         }
    //     }
    //     else
    //     {
    //         if (maybeInt != null)
    //         {
    //             System.Console.WriteLine(maybeInt);
    //             maybeInt = null;
    //         }
    //     }
    // }

    return countPlusNumber;

}

Root();

