// Collection: save several objects in a object
    // Single type: int[] nameArray = new int[4] // {1, 2, 3, 4}
    // Fix size: Array.Resize
    // Index
    // Type safety
// ArrayList -> Not type-safety, Dynamic, Indexing
    // ArrayList myArray = new();
    // myArray.Add(3);
    // Access: in result = (int)myArray[0];
// List -> Type-safety, Dynamic, Indexing
    // System.Collection.Generics
    // List<int> numbers = new();
    // numbers.Add(3);
    // numbers[0];
// Hashset -> Dynamic, type-safety, indexing, unique(the same data can't be added)
    // Hashset<int> myhs = new();
    // myhs.Add(3);
    // myhs.Add(4);
    // myhs.Add(3); -> will not be considered.
    // 3 methods:
        // UnionWith
        // IntersectWith
        // ExceptWith -> HA - HB
// Linked List -> Dynamic, type-safety, memory hunger
    // LinkedList<int> myLl = new();
    // myLl.Add(4);
    // myLl.Add(5);
// Dictionary
    // Dictionary<int, string> myDict = new();
    // myDict.Add(3, "foo"); -> Key, Value
    // myDict[3] -> return "foo"
// Sorted dictionary
    // Sorted based on the key
// Sorted List -> dictionary
    // Sorted based on the key (but the algorithm is different to sorted dictionary)
// KeyValuePair -> a dictionary but the key won't be unique
// Single
    // Stack -> LIFO
        // Stack<int> myStack = new();
        // myStack.Push(3);
        // myStack.Push(5);
        // myStack.Pop(); -> 5: give us the last element pushed ()
        // myStack.Peek(); -> 3: Just see the last (not Pop-ed)
    // Queue -> FIFO
        // Queue<int> myQueue = new();
        // myQueue.Endqueue(3);
        // myQueue.Endqueue(5);
        // myQueue.Dequeue(); -> 3 (poped out)
        // myQueue.Peek(); -> 5

using System.Collections;
using System.Collections.Generic;

namespace MainProgram;
public partial class Program
{
    static void Main(){
        // ArrayList example -> Non type-safety
        ArrayList myArrayList = new();
        myArrayList.Add(3);
        myArrayList.Add("Hello!");
        Print(myArrayList[1]);

        // List example -> Type-safety
        List<int> myList = new();
        myList.Add(5);
        myList.Add(10);        
        Print(myList[1]);

        // Hashset example -> Unique
        HashSet<int> myHs = new();
        myHs.Add(100);
        myHs.Add(20);
        myHs.Add(100);
        myHs.Add(35);
        DisplaySet(myHs);

        // Linked list example -> chain rule (next, before)
        LinkedList<string> myLinkedList = new();
        myLinkedList.AddFirst("My"); // RemoveFirst(), Addlast(), FindLast(),
        myLinkedList.AddLast("name");
        myLinkedList.AddLast("is");
        Display(myLinkedList);

        // Dictionary
        Dictionary<int, string> dict = new();
        dict.Add(3, "foo");
        dict.Add(5, "bar");

        // Sorted dictionary
        SortedDictionary<int, string> dict2 = new(dict);
        foreach(var i in dict2){
            Console.WriteLine(i.Key);
            Console.WriteLine(i.Value);
        }

        // Stack -> LIFO (Last in first out)
        Stack<int> myStack = new();
        myStack.Push(3);
        myStack.Push(10);
        int popResult = myStack.Pop();
        int result = myStack.Peek();
        Print(result); // 3
        Print(popResult); // 10

        // Queue - FIFO (First in first out)
        Queue<string> myQueue = new();
        myQueue.Enqueue("1");
        myQueue.Enqueue("3");
        myQueue.Enqueue("9");
        string resultDequeue = myQueue.Dequeue();
        Print(resultDequeue); // 1
        string resultPeek = myQueue.Peek();
        Print(resultPeek); // 3
    }
}