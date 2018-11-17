namespace HelloWorld
{
    public class numberTester
    {
        static int counter;

        public numberTester()
        {
        }

        public static int getNumber()
        {
            return 10 + counter++;
        }
    }
}