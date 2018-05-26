using System;

namespace Rawfer.Shared
{

    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FoodType Type { get; set; }
        public string ProteinPercent { get; set; }
        public string FatPercent { get; set; }
        public string FiberPercent { get; set; }
        public string MoisturePercent { get; set; }

    }

    public enum FoodType
    {
        Meat,
        Organ,
        Bone,
        Veggie,
        Dairy,
        Supplement,
        Kibble
    }

    public class FoodTime
    {
        public DateTime Time { get; set; }
    }
}
