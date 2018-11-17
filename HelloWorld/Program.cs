using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            // this takes in 2 strings and returns an int from the lambda expressions
            // s1, s2 (are the inputs) => s1.Length + s2.Length is the expression that is evaluated and returned
            Func<string,string,int> totalLength = (s1, s2) => s1.Length + s2.Length;
            int total = totalLength ("hello", "world"); // total is 10;
            Console.WriteLine($"value: { total }");

            var t = doSomething(totalLength);

            //Console.Write("Enter your name:");
            //var Name = Console.ReadLine();
            //Console.WriteLine("Hello {0} World!",Name);
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Number value: {0}, iteration: {1}", numberTester.getNumber(), i);
            //}
            
            //Car car = new Car(4, 4, EngineType.Combustion);
            //Console.WriteLine("Car has {0} doors, {1} wheels, and an {2} engineType", car.getNumberDoors(), car.getNumberWheels(), car.GetEngineType());

            //ElectricCar electricCar = new ElectricCar(4, 2, EngineType.Electric);
            //Console.WriteLine("ElectricCar has {0} doors, {1} wheels, and an {2} EngineType", electricCar.getNumberDoors(), electricCar.getNumberWheels(), electricCar.GetEngineType());
            
            //Vehicle vehicle = new Vehicle(4, 4, EngineType.Combustion);
            //Console.WriteLine("vehicle has an engine type: {0}", vehicle.GetEngineType());
        }

        public static bool doSomething(Func<string,string,int> doIt)
        {
            doIt = (s1, s2) => s1.Length + s2.Length;
            int t = doIt.Invoke("balhasdvadfasd","asdasd");
            return true;
        }

    }

    public class ElectricCar : Vehicle
    {
        int numWheels;
        int numDoors;
        EngineType et;

        public ElectricCar (int wheels, int doors, EngineType engineType)
            : base(wheels, doors, engineType)
        {
            numDoors = doors;
            numWheels = doors;
            et = engineType;
        }
    }
}
