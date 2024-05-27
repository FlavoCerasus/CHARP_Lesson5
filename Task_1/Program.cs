// Вычислить факториал от натурального числа N

int Fact (int number)
{
    if (number == 1 || number == 0)
    {
        Console.WriteLine($"Stop {number}");
        return 1;
    }
    Console.WriteLine(number);
    return number * Fact(number -1);
}
Console.WriteLine(Fact (5));

// F11 - шаг заходом
// F10 - шаг с обходом