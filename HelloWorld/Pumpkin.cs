using System;

namespace HelloWorld
{
    public class Pumpkin : IPlant
    {
        public void grow()
        {
            Console.WriteLine("Let's grow a Pumpkin patch.");
        }
    }
}