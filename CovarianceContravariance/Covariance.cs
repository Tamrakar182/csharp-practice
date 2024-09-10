namespace CovarianceContravariance
{
    class Covariance
    {
        public Covariance()
        {
            List<Dog> dogList = new List<Dog> { new Dog(), new Dog() };
            IEnumerable<Animal> animalList = dogList;

            foreach (Animal animal in animalList)
            {
                animal.Speak();
            }
        }
    }

}