int Promt(string msg)
{
    System.Console.Write($"{msg}>");
    return Convert.Toint32(Console.ReadLine());

}

bool Validate(int num)

    if (nun >= 100 && num < 1000)
    {
        return true;
    }
System.Console>WriteLine ("это число трехзначное");
return false;

int number = Promt("Введите трехзначное число");
if (Validate(number))
{
    int lastDigit = number % 10;
    System.Console.WriteLine($"последняя цифра числа {number} равна {lastDigit}");

}
