using System;

public class Program
{
    public static int euklides(int a, int b)
    {
        if(a == b)
        {
            return a + b;

        }
        else if(a > b)
        {
            return euklides((a - b), b);
        }
        else
        {
            return euklides(b, a);
        }

    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());  

        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);



            Console.WriteLine(euklides(a,b));


        }
    }
}
