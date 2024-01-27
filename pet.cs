namespace pets
{
    public class Pet
    {
        public string Name { get; set; }
        public string Trick { get; set; }
        public string Noise { get; set; }

        public Pet(string name, string trick, string noise)
        {
            Name = name;
            Trick = trick;
            Noise = noise;
        }
    }
}