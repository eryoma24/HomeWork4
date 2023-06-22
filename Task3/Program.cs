int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
int number = ReadInt("Введите целое положительное число => ");
int count = 1;
while (count <= number)
{
    System.Console.WriteLine(count * count * count);
    count ++;
}