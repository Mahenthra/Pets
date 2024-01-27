using pets;

class program
{
    static void Main()
    {
        List<Pet> animals = new List<Pet>();○
        animals.Add(new Fish("Nemo"));
        animals.Add(new Fish("Salma"));
        animals.Add(new Dog("Mio"));
        animals.Add(new Dog("Molly"));
        animals.Add(new Tiger("Ninja"));
        animals.Add(new Tiger("Saber"));


        foreach (Pet pet in animals)
        {
            Console.WriteLine($"Name: {pet.Name}, Noise: {pet.Noise}, Trick: {pet.Trick}");
        }
    }
    
        
    
}