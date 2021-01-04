using System;

namespace HelloWorld
{
    public class Person
    {
        public String firstname;
        public String lastname;

        public Person(String firstname, String lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        
        public void introduce()
        {
            Console.WriteLine("hello " + firstname + " " + lastname);
        }
    }
}