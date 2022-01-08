using System;
namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                Name = "Nguyen Mau Tuan",
                Address = new Address("21 Phu Dong Thien Vuong"),
                Age = 22
            };
            person.Display();
            var person1 = person.ShadowCopy();
            var person2 = person.DeepCopy();
            person.Display();
            person.Age = 23;
            Console.WriteLine("---- Change value shadow -----");
            person.Display();
            person1.Display();
            Console.WriteLine("----Test change value shadow Reference type -----");
            person.Address.name = "70 Phu Dong Thien Vuong";
            person.Display();
            person1.Display();
            
            Console.WriteLine("---- Change value Deep -----");
           person.Display();
           person2.Display();
            
            Console.ReadLine();
        }
    }
}