using System.Text;

class Program
{
    static void Main(){
        using(FileStream fs = new FileStream("test1.txt", 
                                                FileMode.Create, 
                                                FileAccess.Write, 
                                                FileShare.None)){
            string text = "Hello World, Something";
            byte[] myBytes = new byte[text.Length];
            myBytes = Encoding.UTF8.GetBytes(text);
            fs.Write(myBytes, 0, myBytes.Length);
            Console.ReadLine();
        }

        Console.ReadLine(); // the running file (test1.txt) will not be able to be opened if the above code is still running
        Console.WriteLine("continue");

        //Open the stream and read it back.
        using (FileStream fs1 = File.OpenRead("test1.txt"))
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            int readLen;
            while ((readLen = fs1.Read(b,0,b.Length)) > 0)
            {
                Console.WriteLine(temp.GetString(b,0,readLen));
            }
        }

        //Open the stream and read it back.
        using (FileStream fs2 = File.OpenRead("test1.txt"))
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            int readLen;
            while ((readLen = fs2.Read(b,0,b.Length)) > 0)
            {
                Console.WriteLine(temp.GetString(b,0,readLen));
            }
        }

        // Open the text file using a stream reader.
        using (var sr = new StreamReader("test1.txt"))
        {
            // Read the stream as a string, and write the string to the console.
            Console.WriteLine(sr.ReadToEnd());
        }

        // Open the text file using a stream reader.
        using (var sr = new StreamReader("test1.txt"))
        {
            // Read the stream as a string, and write the string to the console.
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}