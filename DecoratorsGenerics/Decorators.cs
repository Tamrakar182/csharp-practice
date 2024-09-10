namespace DecoratorsGenerics
{
    public interface IShape
    {
        void Draw();
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    public class ColoredShapeDecorator : IShape
    {
        private readonly IShape _decoratedShape;
        private readonly string _color;

        public ColoredShapeDecorator(IShape decoratedShape, string color)
        {
            _decoratedShape = decoratedShape;
            _color = color;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a {_color} circle");
            _decoratedShape.Draw();
        }
    }
}