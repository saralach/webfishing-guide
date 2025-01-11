namespace WebfishingGuide.Models
{
    public class Fish
    {
        public string Species { get; set; } = "";
        public string Description { get; set; } = "";
        public string Category { get; set; } = "";

        public double BaseCatchRate { get; set; } = 0;
        public double SparklingLureRate { get; set; } = 0;
        public double FlyHookRate { get; set; } = 0;
        public double LargeLureRate { get; set; } = 0;
        public double MagnetHookRate { get; set; } = 0;
        public double GoldenHookRate { get; set; } = 0;

    }
}
