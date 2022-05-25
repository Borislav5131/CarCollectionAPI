namespace CarCollectionAPI.Data.Models
{
    public class Car
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double HorsePower { get; set; }

        public string Color { get; set; }

        public string Type { get; set; }
    }
}
