class Program {
    static void Main() {
        Thread t1 = new Thread(Printer);// this is the same as the exact thread below
        Thread t2 = new Thread(new ThreadStart(Printer));
        Thread.Sleep(100);

        Thread t3 = new Thread(Printer2); // this is the same as the exact thread below
        Thread t4 = new Thread(new ParameterizedThreadStart(Printer2));
    }
    static void Printer() {
        for(int i = 0; i < 100; i++) {
            Console.Write("+");
        }
    }
    static void Printer2(object obj) {
        for(int i = 0; i < 100; i++) {
            Console.Write(obj);
            Thread.Sleep(100);
        }
    }
}