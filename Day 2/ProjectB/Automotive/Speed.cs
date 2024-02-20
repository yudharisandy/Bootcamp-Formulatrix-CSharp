namespace Automotive;

class Speed
{
    public float velocity;

    //Constructor
    public Speed(float velocity){
        this.velocity = velocity;
    }

    public float Speeding(float velocity){
        this.velocity += 10;
        return this.velocity;
    }
}
