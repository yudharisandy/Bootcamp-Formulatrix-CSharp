class Program {
    static void Main() {

        //Thread is foreground by default
        Console.WriteLine("Program started");
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        Thread thread1 = new Thread(Printer); // Printer1
        Thread thread2 = new Thread(Printer2); // Printer2
        Thread thread3 = new Thread(Printer3); // Printer3
        Thread thread4 = new Thread(Printer4); // Printer4
        Thread thread5 = new Thread(Printer5); // Printer1
        Thread thread6 = new Thread(Printer6); // Printer2
        Thread thread7 = new Thread(Printer7); // Printer3
        Thread thread8 = new Thread(Printer8); // Printer4
        // for (int i = 0; i < 10; i++){
        //     Thread thread
        // }
     
        thread1.Start();
        thread2.Start();
        thread3.Start();
        // thread4.Start();
        // thread5.Start();
        // thread6.Start();
        // thread7.Start();
        // thread8.Start();
        // // Wait for the threads to finish
        // thread1.Join();
        // thread2.Join();
        Console.WriteLine("Program finished");
    }
    static void Printer() {
        Console.WriteLine("Printer1");
        for(int i = 0; i < 100; i++) {
            Console.Write("+");
            Thread.Sleep(500); // ???
        }
    }
    static void Printer2() {
        Console.WriteLine("Printer2");
        for(int i = 0; i < 100; i++) {
            Console.Write("-");
            Thread.Sleep(100);
        }
    }
    static void Printer3() {
        Console.WriteLine("Printer3");
        for(int i = 0; i < 100; i++) {
            Console.Write("/");
            Thread.Sleep(10);
        }
    }
    static void Printer4() {
        Console.WriteLine("Printer4");
        // for(int i = 0; i < 100; i++) {
        //     Console.Write("?");
        // }
    }
    static void Printer5(){
        System.Console.WriteLine("Printer5");
    }
    static void Printer6(){
        System.Console.WriteLine("Printer6");
    }
    static void Printer7(){
        System.Console.WriteLine("Printer7");
    }
    static void Printer8(){
        System.Console.WriteLine("Printer8");
    }
}