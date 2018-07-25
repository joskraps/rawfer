namespace Rawfer.Shared.Models
{
    public class Animal
    {
        public int Age { get; set; } // months

        public string Breed { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string TargetWeight { get; set; }

        public AnimalType Type { get; set; }

        public string Weight { get; set; }
    }
}