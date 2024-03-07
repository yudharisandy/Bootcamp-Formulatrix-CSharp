class Program
{
    static void Main()
    {

        Thread t1 = new Thread(() =>
        {
            try // Use try-catch inside the wapper, instead of in the Start();
            {
                ExceptionMaker();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        });
        try
        {
            t1.Start();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            t1.Join();
        }
        static void ExceptionMaker()
        {
            throw new Exception("Exception thrown from ExceptionMaker");
        }
    }
}