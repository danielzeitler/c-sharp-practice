using System;

namespace HelloWorld
{
    public class TestClass
    {
        public enum Shipping
        {
            RegularMail = 1,
            RegisteredMail = 2,
            Express = 6
        }
        
        static void test(string[] args)
        {
            var random = new Random();
            
            var buffer = new char[10];
            
            for (int i = 0; i < 10; i++)
            {
                buffer[i] = (char) ('a' + random.Next(0, 26));

                var password = new string(buffer);
                Console.WriteLine(password);
            }

            Console.WriteLine();


            // Console.WriteLine((Shipping) 1);

            Console.WriteLine((Enum.Parse(typeof(Shipping), "6")));

            int[] numbers = new int[3] {4, 6, 7};
            string[] somenames = new string[3] {"hello", "my name is ", "john doe"};
            // Console.WriteLine(numbers[0]);

            // concat strings 
            String firstname = "John";
            String lastname = "Doe";
            String fullname = String.Format("{0} {1}", firstname, lastname);

            // join array 
            String joinedArray = String.Join(" - ", somenames);
            Console.WriteLine(joinedArray);
            /*for (int i = 0; i < somenames.Length; i++)
            {
                Console.WriteLine(somenames[i]);
            }*/

            Person person = new Person("daniel", "testuser");
            // person.introduce();

            Car.Car car = new Car.Car(4, "Racer");
            car.BuildCar();
        }
    }
}