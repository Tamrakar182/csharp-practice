// namespace AsyncExample
// {
//     class Program
//     {
//         static async Task Main(string[] args)
//         {
//             await SomethingAsynchronous();
//         }

//         static async Task SomethingAsynchronous()
//         {
//             // making task object and running it
//             Task<int> task1 = Task.Run(() => SomeWork(1, 3000));
//             Task<int> task2 = Task.Run(() => SomeWork(2, 2000));
//             Task<int> task3 = Task.Run(() => SomeWork(3, 1000));

//             // await until all tasks are resolved like Promise.all
//             int[] results = await Task.WhenAll(task1, task2, task3);

//             Console.WriteLine($"Results: {string.Join(", ", results)}");
//         }

//         static int SomeWork(int taskId, int delay)
//         {
//             Console.WriteLine($"Task {taskId} is starting...");
//             Task.Delay(delay).Wait();
//             // delay is like timeout and wait blocks the execution
//             Console.WriteLine($"Task {taskId} is completed.");
//             return taskId * 10;
//         }
//     }
// }

// namespace IOExample
// {
//     class Program
//     {
//         static async Task Main(string[] args)
//         {
//             Console.WriteLine("Starting async I/O demo...");

//             string content = await ReadFileAsync("example.txt");

//             Console.WriteLine("File content:");
//             Console.WriteLine(content);

//             Console.WriteLine("Async I/O demo completed.");
//         }

//         static async Task<string> ReadFileAsync(string filePath)
//         {
//             try
//             {
//                 using (StreamReader reader = new StreamReader(filePath))
//                 {

//                     return await reader.ReadToEndAsync();
//                 }
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"An error occurred: {ex.Message}");
//                 return string.Empty;

//             }
//         }
//     }
// }

// namespace HTTPExample
// {
//     class Program
//     {
//         static async Task Main(string[] args)
//         {
//             Console.WriteLine("Starting async web request demo...");

//             string url = "https://dummyjson.com/products/?limit=1";
//             string content = await FetchDataAsync(url);
//             Console.WriteLine("Web request content:");
//             Console.WriteLine(content);

//             Console.WriteLine("Async web request demo completed.");
//         }

//         static async Task<string> FetchDataAsync(string url)
//         {
//             try
//             {

//                 using (HttpClient client = new HttpClient())
//                 {
//                     HttpResponseMessage response = await client.GetAsync(url);
//                     response.EnsureSuccessStatusCode();
//                     return await response.Content.ReadAsStringAsync();
//                 }
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"Error Occurred: {ex}");
//                 return string.Empty;
//             }
//         }
//     }
// }