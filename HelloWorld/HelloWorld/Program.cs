using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3] {4, 6, 7};
            string[] somenames = new string[3] {"hello", "my name is ", "john doe"};
            // Console.WriteLine(numbers[0]);

            // concat strings 
            String firstname = "John";
            String lastname = "Doe";
            String fullname = String.Format("{0} {1}", firstname, lastname);

            // join array 
            String joinedArray = String.Join(".", somenames);
            for (int i = 0; i < somenames.Length; i++)
            {
                Console.WriteLine(somenames[i]);
            }

            Person person = new Person("daniel", "testuser");
            // person.introduce();

            Car.Car car = new Car.Car(4, "Racer");
            car.BuildCar();
        }
    }
}