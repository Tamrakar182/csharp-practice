namespace Singleton
{
    public sealed class Counter
    {
        private static Counter? _instance;
        private int _count;

        private Counter() { }

        public static Counter GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Counter();
            }
            return _instance;
        }

        public void Increment()
        {
            _count++;
        }

        public int GetCount()
        {
            return _count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Counter mainCallCounter = Counter.GetInstance();
            mainCallCounter.Increment();
            Console.WriteLine($"Main function called {mainCallCounter.GetCount()} times.");

            Counter buttonClickCounter = Counter.GetInstance();

            for (int i = 0; i < 5; i++)
            {
                buttonClickCounter.Increment();
            }

            Console.WriteLine($"Button clicked {buttonClickCounter.GetCount()} times.");
        }

    }
}