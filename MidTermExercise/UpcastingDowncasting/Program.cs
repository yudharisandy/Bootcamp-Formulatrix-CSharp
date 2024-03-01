﻿// Upcasting (small -> large) -> implicit upcasting (automatically)
// Downcasting (large -> small) -> need explisit downcasting

class Program
{
    static void Main(){
        // Upcasting (automatically do implicit upcasting)
        int a = 2;
        double b = a;
        Console.WriteLine(a);
        Console.WriteLine(b);

        // Downcasting (need to do explicit downcasting -> if no, then error)
        // double c = 2;
        // int d = c;
        // Console.WriteLine(d);

        // Downcasting (with explicit downcasting)
        double c = 2.001;
        int d = (int) c;
        Console.WriteLine(c);
        Console.WriteLine(d);

        // Downcasting (explicit downcasting - mandatory)
        float e = 3.01f;
        int f = (int) e;
        Console.WriteLine(e);
        Console.WriteLine(f);

        // Downcasting (need explicity downcasting)
        double g = 5.005;
        float h = (float) g;
        Console.WriteLine(g);
        Console.WriteLine(h);

        // Upcasting (implicit upcasting)
        float i = 10.89f;
        double j = i;
        Console.WriteLine(i);
        Console.WriteLine(j);
    }
}