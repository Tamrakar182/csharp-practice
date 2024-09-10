using System.Collections;

namespace IteratorsCollections
{
    class Program
    {
        public static IEnumerable<int> Numbers()
        {
            yield return 3;
            yield return 5;
            yield return 8;
            // breaks execution
            // yield break;
            yield return 9;
        }

        public static IEnumerable<int>
    Even(int firstNumber, int lastNumber)
        {
            for (int number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }

        public class Stack<T> : IEnumerable<T>
        {
            private T[] values = new T[100];
            private int top = 0;

            public void Push(T t)
            {
                values[top] = t;
                top++;
            }
            public T Pop()
            {
                top--;
                return values[top];
            }

            public IEnumerator<T> GetEnumerator()
            {
                for (int index = top - 1; index >= 0; index--)
                {
                    yield return values[index];
                }
            }

            IEnumerator<T> IEnumerable<T>.GetEnumerator()
            {
                return GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            foreach (int number in Numbers())
            {
                Console.Write(number.ToString() + " ");
            }
            Console.WriteLine();

            foreach (int number in Even(5, 18))
            {
                Console.Write(number.ToString() + " ");
            }
            Console.WriteLine();

            Stack<int> newStack = new();

            for (int number = 0; number <= 9; number++)
            {
                newStack.Push(number);
            }
            Console.Write("Before Pop: ");
            foreach (int number in newStack)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
            Console.Write("Pop: ");
            Console.Write(newStack.Pop());
            Console.WriteLine();
            Console.Write("After Pop: ");
            foreach (int number in newStack)
            {
                Console.Write("{0} ", number);
            }
        }
    }
}