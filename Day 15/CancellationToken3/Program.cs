class Program
{
    static void Main(){
        // Create 2 ultrasonic sensors
        Ultrasonic sensor1 = new(1);
        Ultrasonic sensor2 = new(2);
        Robot robot = new();

        bool moveForward = new();
        bool status = moveForward;

        //Create task to work independently each sensor
        Task sensor1Task = Task.Run(() => sensor1.ReadSensor());
        Task sensor2task = Task.Run(() => sensor2.ReadSensor());
        
        Task robotTask = Task.Run(() => robot.MoveForward());
    }
}
class Ultrasonic
{
    private int _id;
    public Ultrasonic(int id){
        _id = id;
    }
    public int ReadSensor(){
        // .. method to access sensor
        int result = 1;
        return result;
    }
}
class Robot
{
    public void MoveForward(){

    }
}