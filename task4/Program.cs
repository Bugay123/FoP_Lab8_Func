internal class Program
{
    /*4.Створити метод обчислення індексу мінімального елементу масиву
        і самого значення мін. елементу. Індекс повернути в операторі return,
        значення через параметр out. В методі Main створити 2 масиви і
        обчислити суму мін. елементів обох масивів. Результати вивести на
        консоль.*/

    static int FindMin(int[] mas, out int min)
    {
       min = mas[0];
       int minIndex = 0;
       for (int i = 0; i < mas.Length; i++)
        {
            if (min > mas[i])
            {
                min = mas[i];
                minIndex = i;
            }
        }
        return minIndex;
    }

    private static void Main(string[] args)
    {
        int[] mas1 = { 0, 1, 2, 3, 4, -5, 6, 7, 8, 9 };
        int[] mas2 = { 19, 18, 17, 16, 15, 14, 13, 12, 11, 10 };
        int min1, min2;
        Console.WriteLine($"Мінімальний індекс: {FindMin(mas1, out min1)}, мiнімальне число: {min1}");
        Console.WriteLine($"Мінімальний індекс: {FindMin(mas2, out min2)}, мiнімальне число: {min2}");

    }
}