class Program
{
    /*1.Створити метод обчислення значення функції у заданій точці x.
        Значення x передати як параметр. Функція F задається таким чином:
            F(x) = 14x+20, x<0
            F(x) = 25x+10, x>0
            F(x) = 0, x = 0
        В методі Main обчислити значення F для у трьох точках: x<0, x>0,x=0.
        Результати вивести на консоль.*/
    static int Func (int x)
    {
        int result = 0;
        if (x == 0){ return result; }

        if (x < 0)
        {
            result = 14 * x + 20;
        }
        else
        {
            result = 25*x + 10;
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("x < 0: " + Func(-5));
        Console.WriteLine("x > 0: " + Func(5));
        Console.WriteLine("x = 0: " + Func(0));
    }
}