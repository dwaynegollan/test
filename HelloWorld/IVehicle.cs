namespace HelloWorld
{
    public interface IVehicle
    {
         int getNumberDoors();
         int getNumberWheels();

         EngineType GetEngineType();


    }

    public enum EngineType
    {
        Combustion = 1,
        Hybrid = 2,
        Electric = 3
    }
}