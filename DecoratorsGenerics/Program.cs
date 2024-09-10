namespace DecoratorsGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IShape circle = new Circle();
            circle.Draw();

            IShape redCircle = new ColoredShapeDecorator(circle, "red");
            redCircle.Draw();

            LinkedList<string> names = new LinkedList<string>();
            names.Add("Ram");
            names.Add("Harry");
            names.Add("Puttar");

            Console.WriteLine(names);
        }
    }
}
