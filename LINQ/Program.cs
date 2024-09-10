namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Enumerable.Range(1, 10).ToList();

            // LINQ using SQL like syntax
            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;

            // LINQ using method syntax
            var oddNumbers = numbers.Where(n => n % 2 != 0);

            // Projection
            var squaredNumbers = numbers.Select(n => n * n);

            // Order by
            var orderedNumbers = numbers.OrderBy(n => n);
            var descendingNumbers = numbers.OrderByDescending(n => n);

            // Group by
            var groupedNumbers = from number in numbers
                                 group number by number % 2 into g
                                //  Here key is the group, 0 for even and 1 for odd
                                 select new { Key = g.Key, Numbers = g };

            PrintNumbers("Even: ", evenNumbers);
            PrintNumbers("Odd: ", oddNumbers);
            PrintNumbers("Squares: ", squaredNumbers);
            PrintNumbers("Descending Order: ", descendingNumbers);

            Console.WriteLine("Grouped: ");
            foreach (var group in groupedNumbers)
            {
                Console.WriteLine($"Key: {group.Key}");
                foreach (var num in group.Numbers)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintNumbers<T>(string title, IEnumerable<T> numbers)
        {
            Console.WriteLine(title);
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
