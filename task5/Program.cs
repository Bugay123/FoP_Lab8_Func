using System;

internal class Program
{
    /*5.Розробити програму створення одновимірного масиву розміру [25],
        заповнення його випадковими числами в діапазоні [1,45]. Для
        заповнення масиву створити окремий метод. Масив передати в метод
        як параметр. В другому методі обчислити середнє арифметичне
        елементів і кількість однакових елементів, які співпадають з першим елементом (через out).
        В методі Main оголосити змінну масиву і викликати методи.
        Результати вивести на консоль.*/

    static void aRandom (int[] mas)
    {
        Random rnd = new Random();
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = rnd.Next(1, 5);
        }
    }

    static double Arif(int[] mas, out int count)
    {
        count = mas.Length - mas.Distinct().Count();
        return (double) mas.Sum() / mas.Length;
    }

    private static void Main(string[] args)
    {
        int[] mas = new int[5];
        int count;
        aRandom(mas);
        Console.WriteLine("Массив: ");
        for (int i =0; i < mas.Length; i++)
        {
            Console.Write(mas[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine($"Середне значення елементів: {Arif(mas, out count)}, однакових елементів {count}");
    }
}