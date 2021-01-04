namespace HelloWorld {
    class Program {
        static void Main(string[] args)
        {
            Person person = new Person("daniel", "testuser");
            person.introduce();

            Car.Car car = new Car.Car(4, "Racer");
            car.BuildCar();
        }
    }
}


