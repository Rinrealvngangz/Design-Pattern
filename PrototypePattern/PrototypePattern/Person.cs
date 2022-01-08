using System;

namespace PrototypePattern
{
    public class Person : ICloneable<Person>
    {
        public string Name  { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public void Display()
        {
            Console.WriteLine($"Person Name:{Name} - Address:{Address.name} - Age:{Age}");
        }

        public Person ShadowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            var person = (Person)this.MemberwiseClone();//shadow
            person.Address = new Address(Address.name);
            return person;
        }

      
    }
}