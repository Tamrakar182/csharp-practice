namespace Indexers
{
    public class PhoneBookIndexer
    {
        private string[] phoneNumbers = new string[10];

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= phoneNumbers.Length)
                    throw new IndexOutOfRangeException("Index out of range");
                return phoneNumbers[index];
            }
            set
            {
                if (index < 0 || index >= phoneNumbers.Length)
                    throw new IndexOutOfRangeException("Index out of range");
                phoneNumbers[index] = value;
            }
        }
    }

    public class PhoneBookProperty
    {
        private string[] phoneNumbers = new string[10];
        public string GetPhoneNumber(int index)
        {
            return phoneNumbers[index];
        }

        public void SetPhoneNumber(int index, string value)
        {
            phoneNumbers[index] = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhoneBookIndexer phoneBookIndexer = new PhoneBookIndexer();
            PhoneBookProperty phoneBookProperty = new PhoneBookProperty();

            phoneBookIndexer[0] = "98XXXXXX";
            phoneBookIndexer[1] = "98XXXXXX";

            phoneBookProperty.SetPhoneNumber(0, "9823412312");
            phoneBookProperty.SetPhoneNumber(1, "538492432");

            Console.WriteLine($"PhoneIndexer 1: {phoneBookIndexer[0]}");
            Console.WriteLine($"PhoneIndexer 2: {phoneBookIndexer[1]}");

            Console.WriteLine($"PhoneProperty 1: {phoneBookProperty.GetPhoneNumber(0)}");
            Console.WriteLine($"PhoneProperty 2: {phoneBookProperty.GetPhoneNumber(0)}");

        }
    }
}