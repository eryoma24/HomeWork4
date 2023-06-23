int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int inputedValue = Convert.ToInt32(Console.ReadLine());
    return inputedValue;
}
int x1 = ReadInt("Введите координату x первой точки => ");
int y1 = ReadInt("Введите координату y первой точки => ");
int z1 = ReadInt("Введите координату z первой точки => ");
int x2 = ReadInt("Введите координату x второй точки => ");
int y2 = ReadInt("Введите координату y второй точки => ");
int z2 = ReadInt("Введите координату z второй точки => ");
double Lenght(int x, int y, int z)
{
    double temp = (x * x) + (y * y) + (z * z);
    return Math.Sqrt(temp);
}
double distance = Lenght(x2 - x1, y2 - y1, z2 - z1);
System.Console.WriteLine($"Расстояние между двумя точками равно {distance}");