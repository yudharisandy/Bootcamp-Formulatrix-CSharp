class Program
{
    static void Main(){
        using(FileStream fs = new FileStream("newFile.txt", FileMode.Create, FileAccess.Write))
        {
            string[] inputWorld = {"Aello world 1", "Hello world 2", "Hello world 3"};
            using(StreamWriter outputFile = new StreamWriter(fs))
            {
                foreach(var word in inputWorld){
                    outputFile.WriteLine(word);
                }
            }
        }

        // Read the file using StreamReader
        using(StreamReader inputFile = new StreamReader("newFile.txt"))
        {
            // Console.WriteLine(inputFile.ReadToEnd()); // Read all lines
            // Console.WriteLine(inputFile.Read());     // Return the Decimal (from ASCII code) of the first character in the stream
            Console.WriteLine(inputFile.ReadLine()); // Read first line
            Console.WriteLine(inputFile.ReadLine()); // Read second line
            Console.WriteLine(inputFile.ReadLine()); // Read third line
        }

        // Write (add) the new line to existing file
        using(FileStream fs = new FileStream("newFile.txt", FileMode.Append, FileAccess.Write))
        {
            using(StreamWriter outputFile = new StreamWriter(fs))
            {
                outputFile.WriteLine("Hello world 4");
            }
        }

        // Write (add) the new line to existing file, directly from StreamWriter
        using(StreamWriter outputFile = new StreamWriter("newFile.txt", true)) // Set append = true
        {
            outputFile.WriteLine("Hello world 5");
        }

        // Explore SeekOrigin
        using(FileStream fs = new FileStream("newFile2.txt", FileMode.Create, FileAccess.Write)){
            using(StreamWriter outputFile = new StreamWriter(fs)) // Set append = true
            {
                outputFile.WriteLine("Hello world 6");
                fs.Seek(-1, SeekOrigin.End);
                outputFile.WriteLine("Hello world 7");
            }
        }
    }
}