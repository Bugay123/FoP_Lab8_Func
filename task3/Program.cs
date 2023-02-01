internal class Program
{
    /*3.Створити метод обчислення вказаної кількості чисел Фібоначчі і
        зберігання їх в масиві. Кількість чисел передати в метод як параметр.
        Заповнений масив повернути в метод Main і вивести на консоль.*/

    static int MasFibo(int num)
    { 
        if (num == 0 || num == 1) { return num; }
        return MasFibo(num - 1) + MasFibo(num - 2);
    }

    private static void Main(string[] args)
    {
        int numCount = 10;
        int[] mas = new int[numCount];
        for(int i = 0; i < mas.Length; i++)
        {
            mas[i] = MasFibo(i);
            Console.WriteLine(mas[i]);
        }
    }
        
}