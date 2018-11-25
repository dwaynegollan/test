using static HelloWorld.Plants;

namespace HelloWorld
{
    public static class PlantFactory
    {
        public static IPlant Create(PlantType plantType)
        {
            switch (plantType)
            {
                case PlantType.Watermelon:
                    return new Watermelon();
                case PlantType.Apple:
                    return new Apple();
                case PlantType.Orange:
                    return new Orange();
                case PlantType.Pumpkin:
                    return new Pumpkin();
                default:
                    return null;
            }
        }
    }
}