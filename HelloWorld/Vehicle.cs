namespace HelloWorld
{
    public class Vehicle : IVehicle
    {
        int numberOfDoors;
        int numberOfWheels;
        EngineType engineType;

        public Vehicle(int numWheels, int numDoors, EngineType et)
        {
            numberOfWheels = numWheels;
            numberOfDoors = numDoors;
            engineType = et;
        }

        public EngineType GetEngineType()
        {
            return engineType;
        }

        public int getNumberDoors()
        {
            return numberOfDoors;
        }

        public int getNumberWheels()
        {
            return numberOfWheels;
        }
    }
}