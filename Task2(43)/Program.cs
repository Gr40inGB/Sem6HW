// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Если k1 = k2 прямые не пересукутся 
// иначе - ищем по формуле x = (b2-b1)/(k1-k2);
//                         y =  k1 * x + b1      или  y = k1 * (b2-b1) / (k1-k2) + b1

void main()
{
    Console.Clear();
    Console.WriteLine($"Программа найдет точку пересечения между прямыми с указанными параметрами:\nПервая прямая: y = k1 * x + b1\nВторая прямая: y = k2 * x + b2;\n");
    System.Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine();
    if (k1 == k2 && b1 == b2) System.Console.WriteLine("Эти прямые совпадают");
    else if (k1 == k2) System.Console.WriteLine("Прямых совпадают угловые коэффициенты - они не пересекутся");
    else
    {
        double[] crossPoint = SearchCrossPoint(k1, b1, k2, b2);
        System.Console.WriteLine($"Точка пересечения X = {crossPoint[0]}, Y = {crossPoint[1]}");
    }
}

double[] SearchCrossPoint(double K1, double B1, double K2, double B2)
{
    double[] xyArray = new double[2];
    xyArray[0] = (B2 - B1) / (K1 - K2);
    xyArray[1] = K1 * (B2 - B1) / (K1 - K2) + B1;
    return xyArray;
}

main();