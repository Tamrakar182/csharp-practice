
namespace CovarianceContravariance
{
    class AnimalComparer : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Cannot compare null values");
            }

            return string.Compare(x.GetType().Name, y.GetType().Name, StringComparison.Ordinal);
        }
    }

    class Contravariance
    {
        public Contravariance()
        {
            IComparer<Animal> animalComparer = new AnimalComparer();
            IComparer<Dog> dogComparer = animalComparer;

            var dogs = new List<Dog> { new Dog(), new Dog() };
            dogs.Sort(dogComparer);

            foreach (var dog in dogs)
            {
                dog.Speak();
            }
        }
    }

}