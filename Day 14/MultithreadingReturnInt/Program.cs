// using System;
// using System.Threading;

class Program
{
    static void Main(){
        int result = 0;
        int resultInt = 0;
        bool status = false;
        Thread thread = new Thread(() => Add(3, 4, ref result));
        Thread thread2 = new Thread(() => ChangeStatus(ref status));
        Thread thread3 = new Thread(() => resultInt = AddInt(3, 4));
        thread.Start();
        thread2.Start();
        thread3.Start();
        thread.Join();
        System.Console.WriteLine(result);
        System.Console.WriteLine(status);
        System.Console.WriteLine(resultInt);
    }
    static int AddInt(int a, int b){
        return a + b;
    }
    static void Add(int a, int b, ref int result){
        result = a + b;
    }
    static void ChangeStatus(ref bool status){
        if(status == true){
            status = false;
            
        }
        else{
            status = true;
        }
    }
}
