// [Polymorphism]
// Overriding (keyword: virtual and override) (implementasi di parent diambl alih oleh anak)
    // the parent function is erasaed. child function is exist.
// Method hiding (there is no 'override') - both functions are still exist

using Animals;
class Program
{
    static void Main(){
        Cat cat = new Cat();
        // cat.Sound();

        Dog dog = new Dog();
        // dog.Sound();

        Ant ant = new Ant();
        // ant.Sound();
        
        Anggora anggora = new Anggora();
        anggora.Sound();

        // MakeSound(cat);
        // MakeSound(dog);
        // MakeSound(ant);
        MakeSound(anggora);
        
    }

    static void MakeSound(Animal animal){
        animal.Sound();
    }
}
