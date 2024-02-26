// Create methods included in class Program in other file.cs
// filename ex: Program.Display.cs (Display -> random)
// public partial class Program
// still in the same namespace
// Delete item group in the .csproj (if necessary)

namespace PartialExample;
public partial class Program
{
    static void Main(){
        Print("Here is the message");
        Read();
    }
}
