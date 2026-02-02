using System;
class Evv
{
    static void Main()
    {
       int num= number();
        Console.WriteLine(num);
        
    }
    static int number()
    {
        Console.WriteLine("enter a number to check");
        int num = int.Parse(Console.ReadLine());
        if ((num / 2) * 2 == num)
        {
            Console.WriteLine("num is even");
            return num;
        }
        else
        {
            Console.WriteLine("num is odd");
            return num;
        }
    }
}
