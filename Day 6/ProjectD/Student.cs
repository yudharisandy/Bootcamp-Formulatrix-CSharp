namespace Classroom;


class Student
{
    public int score;
    // Constructor
    public Student(int score){
        this.score = score;
    }
    // Operator overloading (for "+" operator)
    public static Student operator +(Student A, Student B){
        return new Student(A.score + B.score);
    }
    // Operator overloading (for "/" operator)
    public static Student operator /(Student A, Student B){
        return new Student(A.score / B.score);
    }
}
