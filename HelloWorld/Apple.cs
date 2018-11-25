using System;

namespace HelloWorld
{
    public class Apple : IPlant
    {
        public void grow()
        {
            Console.WriteLine("Let's grow an Apple tree.");
        }
    }
}