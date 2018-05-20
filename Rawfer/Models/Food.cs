namespace Rawfer.Models
{
    public enum FoodType
    {
        Meat,
        Veggie,
        Grain,
        Dairy,
        Fish,
        Vitamin
    }

    public class Food
    {
        public int Id { get; set; }
        public FoodType Type { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public double ProteinPercent { get; set; }
        public double FatPercent { get; set; }
        public double FiberPercent { get; set; }
        public double MoisturePercent { get; set; }
        public FoodSource[] Sources { get; set; }
    }

    public class FoodSource
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }

    public class MealPlan
    {

    }
}
