namespace Rawfer.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; } //age in months
        public AnimalType Type { get; set; }
        public double Weight { get; set; }
        public double TargetWeight { get; set; }
        public string Breed { get; set; }
        public Condition[] Conditions { get; set; }
        public Note[] Notes { get; set; }
    }

    public enum AnimalType
    {
        Dog,
        Cat,
        Ferret,
        Other
    }
}
