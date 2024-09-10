
namespace AnonFuncLambda
{
    delegate int IncrementByDelegate(int source, int increment = 1);
    class Program
    {
        public static async Task Main(string[] args)
        {
            // anonymous function using lambda expression
            Func<int, int, int> operation = (x, y) => x + y;

            // anonymous function with delegate initialisation
            var IncrementBy = (int source, int increment = 1) => source + increment;

            int result = operation(5, 3);
            int increaseBy1 = IncrementBy(5);

            Console.WriteLine($"result: {result}, increaseBy1: {increaseBy1}");

            // asynchronous lambda
            Func<Task> asyncLambda = async () =>
            {
                await SomeAsyncTask();
            };

            await asyncLambda();
        }

        private static async Task SomeAsyncTask()
        {
            await Task.Delay(1000);
            Console.WriteLine("Async task completed.");
        }
    }
}