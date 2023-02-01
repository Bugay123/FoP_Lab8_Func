internal class Program
{
    /*2.Створити метод обчислення суми цифр довільного числа. В методі
        Main викликати цей метод для обчислення суми цифр чисел 125 тa 68.
        Результати вивести на консоль.*/

    static int SumNum(int num)
    {
        int sum = 0;
        int lastDigit = 0;
        while (num != 0)
        {
            lastDigit = num % 10;
            sum = sum + lastDigit;
            num = num / 10;
        }
        return sum;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Сумма 2-х: " + SumNum(125));
        Console.WriteLine("Сумма 3-х: " + SumNum(68));
    }
}