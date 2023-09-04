public class Zoo
{
    private List<Animal> animals;

    public Zoo()
    {
        animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void MakeSounds()
    {
        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }
}