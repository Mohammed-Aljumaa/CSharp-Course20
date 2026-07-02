using System;
using System.IO;
using System.Runtime.Serialization.Json;


[Serializable]

public class Person
{

    public string Name { get; set; }

    public int Age { get; set; }


}

public class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Name = "Mohammed";
        person.Age = 77;


        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));
        using (MemoryStream stream = new MemoryStream())
        {

            serializer.WriteObject(stream, person);

            string jsonString =System.Text.Encoding.UTF8.GetString(stream.ToArray());


            File.WriteAllText("Person.json", jsonString);



        }


        using (FileStream stream1 = new FileStream("Person.json", FileMode.Open))
        {


            Person deSerialized =(Person) serializer.ReadObject(stream1);

            Console.WriteLine($"Name : {deSerialized.Name}, Age : {deSerialized.Age}" );
        }



    }



}