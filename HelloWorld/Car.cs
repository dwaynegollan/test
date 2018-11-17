namespace HelloWorld
{
    public class Car : Vehicle
    {
        int numWheels;
        int numDoors;
        EngineType et;

        public Car (int wheels, int doors, EngineType engineType)
            : base(wheels, doors, engineType)
        {
            numDoors = doors;
            numWheels = doors;
            et = engineType;
        }
    }
}