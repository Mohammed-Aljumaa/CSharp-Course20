using System;
using System.IO;
using System.Xml.Serialization; 


[Serializable]
public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }




}

public class Program
{
    static  void Main()
    {

        Person person = new Person();
        person.Name = "Mohammed";
        person.Age = 33;


        XmlSerializer serializer = new XmlSerializer(typeof(Person));
        using (TextWriter writer =new StreamWriter("person.xml"))
        {


            serializer.Serialize(writer, person);

        }


        using(TextReader reader =new StreamReader("person.xml"))
        {
            Person deserializedPerson=(Person)serializer.Deserialize(reader);

            Console.WriteLine($"Name : {deserializedPerson.Name},Age : {deserializedPerson.Age}");
        }



        
    }




}
