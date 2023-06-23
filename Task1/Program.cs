int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int numbers5 = Convert.ToInt32(Console.ReadLine());
    return numbers5;
}
int number = ReadInt("Введите пятизначное целое число => ");

if ((number / 10000 == number % 10) && (number / 1000 % 10 == number / 10 % 10))
{
    System.Console.WriteLine($"{number} является палиндромом");
}
else{
    System.Console.WriteLine($"{number} не является палиндромом");
}