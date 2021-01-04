using System;

namespace HelloWorld.Car
{
    public class Car
    {
        public int wheels;
        public String name;

        public Car(int wheels, String name)
        {
            this.wheels = wheels;
            this.name = name;
        }

        public void BuildCar()
        {
            Console.WriteLine("this is my car with " + wheels + " and it's name is " + name);
        }
    }
}