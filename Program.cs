int Promt(string msg)
{
    System.Console.Write($"{msg}>");
    return Convert.Toint32(Console.ReadLine());

}

int number = Promt('Введите трехзначное число');
if (number >= 100 &&  number < 1000)
{
    int lastDigit = number % 10;
    System.Console.WriteLine($"последняя цифра числа {number} равна {lastDigit}");

}
else 
{
    System.Console.WriteLine("Это число не трехзначное");

}