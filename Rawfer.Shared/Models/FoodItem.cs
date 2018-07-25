namespace Rawfer.Shared.Models
{
    public class FoodItem
    {
        public string FatPercent { get; set; }

        public string FiberPercent { get; set; }

        public int Id { get; set; }

        public string MoisturePercent { get; set; }

        public string Name { get; set; }

        public string ProteinPercent { get; set; }

        public FoodType Type { get; set; }
    }
}