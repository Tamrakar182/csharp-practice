namespace CovarianceContravariance
{
    class Animal
    {
        public virtual void Speak() => Console.WriteLine("Animal speaks");
    }

    class Dog : Animal
    {
        public override void Speak() => Console.WriteLine("Dog barks");
    }

    class Program
    {
        static void Main()
        {
            Covariance covarianceExample = new();

            Contravariance contravarianceExample = new();
        }
    }

}
