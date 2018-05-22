namespace Rawfer.Shared
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AnimalType Type { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; } //months
        public string Weight { get; set; }
        public string TargetWeight { get; set; }
    }

    public enum AnimalType
    {
        Dog,
        Cat,
        Ferret,
        Bird
    }
}
