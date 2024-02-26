namespace Classroom;

class Teacher
{
    public bool boolScore;
    public int score;
    // Constructor
    public Teacher(int score, bool boolScore){
        this.score = score;
        this.boolScore = boolScore;
    }
    // Operator overloading (for "+" operator)
    public static Teacher operator ==(Teacher A, Teacher B){
        return new Teacher(100, A.boolScore == B.boolScore);
    }
    // // Operator overloading (for "/" operator)
    // public static Student operator /(Student A, Student B){
    //     return new Student(A.score / B.score);
    // }
}
