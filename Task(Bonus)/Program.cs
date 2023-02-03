// Задача со звездочкой. Напишите программу, 
// которая реализует обход введенного двумерного массива, 
// начиная с крайнего нижнего левого элемента против часовой стрелки.

// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

int[,] GetFilledArray(int sizeX, int sizeY, int minValue, int maxValue)
{
    int[,] ArrayForFill = new int[sizeY, sizeX];
    for (int iY = 0; iY < sizeY; iY++)
    {
        for (int iX = 0; iX < sizeX; iX++)
        {
            ArrayForFill[iY, iX] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return ArrayForFill;
}

int[,] TurnArray(int[,] arrayToTurn)
{
    int[,] turnedArray = new int[arrayToTurn.GetLength(1), arrayToTurn.GetLength(0)];

    for (int i = 0; i < arrayToTurn.GetLength(1); i++)
        for (int j = 0; j < arrayToTurn.GetLength(0); j++)
            turnedArray[i, j] = arrayToTurn[arrayToTurn.GetLength(0) - j - 1, i];
    return turnedArray;
}

int[,] cutLine(int[,] arrayToCutLine)
{
    int[,] tempArray = new int[arrayToCutLine.GetLength(0) - 1, arrayToCutLine.GetLength(1)];
    for (int i = 0; i < arrayToCutLine.GetLength(0) - 1; i++)
        for (int j = 0; j < arrayToCutLine.GetLength(1); j++)
            tempArray[i, j] = arrayToCutLine[i, j];
    return tempArray;
}

int[,] SnakeEat(int[,] ArrayForSpiral)   // проходим по нижней строке слева направо - записываем все значения
{
    int hight = ArrayForSpiral.GetLength(0);
    int Width = ArrayForSpiral.GetLength(1);

    for (int x = 0; x < Width; x++)
    {
        System.Console.Write($"{ArrayForSpiral[hight - 1, x]} ");
    }
    return ArrayForSpiral;
}

void main()
{
    Console.Clear();
    Random randomSize = new Random();
    int[,] OurArray = GetFilledArray(randomSize.Next(4, 6), randomSize.Next(5, 8), 1, 9);

    for (int iY = 0; iY < OurArray.GetLength(0); iY++)
    {
        for (int iX = 0; iX < OurArray.GetLength(1); iX++)
        {
            System.Console.Write($" {OurArray[iY, iX]} ");
        }
        System.Console.WriteLine();
    }

    System.Console.WriteLine();

    while (OurArray.Length > 0) /// повторяем пока не получим нулевой массив
    {
        OurArray = SnakeEat(OurArray); // проходим по нижней строке слева направо 
        OurArray = cutLine(OurArray);  // отрезаем пройденную линию 
        OurArray = TurnArray(OurArray); // переворачиваем массив по часовой стрелке
    }
}

main();