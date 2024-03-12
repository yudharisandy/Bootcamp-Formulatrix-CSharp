// To serialize the private variable or property

using System.Data;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

//DataContract attribute is used to mark the class as serializable
[DataContract]
class Human 
{
	[DataMember]
	private string name;
	[DataMember]
	private int age;
    [DataMember]
    public int Gold {get; set;} // will be saved first, due to "upper letter"
    [DataMember]
    public int money;
	public Human(string name, int age, int money) 
	{
		this.name = name;
		this.age = age;
        this.money = money;
        this.Gold = money;
	}
	public string GetName() 
	{
		return name;
	}
	public int GetAge()
	{
		return age;
	}
}
class Program 
{
	static void Main() 
	{
		// Serializer
		Human human1 = new Human("John", 25, 100);
        Human human2 = new Human("Alex", 40, 150);
        List<Human> humans = new(){human1, human2};

		// DataContractJsonSerializer serializer = new(typeof(Human));
        DataContractJsonSerializer serializer = new(typeof(List<Human>));
		using(FileStream sw = new("human.json", FileMode.Create))
		{
			serializer.WriteObject(sw, humans);
		}

		// //Deserializer
        // // DataContractJsonSerializer serializer = new(typeof(List<Human>));
		// // Human results;
        // List<Human> results;
		// using(FileStream sr = new("human.json", FileMode.Open))
		// {
		// 	results = (List<Human>)serializer.ReadObject(sr);
		// }
        // foreach(var human in results){
        //     Console.WriteLine(human.GetName());
        //     Console.WriteLine(human.GetAge());
        // }
	}
}