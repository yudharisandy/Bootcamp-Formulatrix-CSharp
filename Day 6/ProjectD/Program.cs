// Operator overloading
    // Syarat: static method
    // public static Car operator +(Car a, Car b){
        // return new Car(a.price + b.price);
    // }
    // Car car3 = car1 + car2;
    // List of operators: / | * | + | - | == | % | < | > | ++ | -- | !=

using Classroom;

class Program
{
    static void Main(){
        Student studentA = new(100);
        Student studentB = new(80);
        Student studentC = new(60);

        // Can't directly do the following -> Need operator "+" overloading
        Student studentD = studentA + studentB;
        Console.WriteLine(studentD.score);

        // Operator "/" overloading
        Student studentE = studentA / studentB;
        Console.WriteLine(studentE.score);

        // Teacher example
        Teacher teacher1 = new(100, true);
        Teacher teacher2 = new(50, false);
        Teacher teacher3 = (teacher1 == teacher2);
        Console.WriteLine(teacher3.boolScore);
    }
}
