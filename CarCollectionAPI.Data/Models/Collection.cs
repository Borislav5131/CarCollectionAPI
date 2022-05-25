namespace CarCollectionAPI.Data.Models
{
    public class Collection
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Car> Cars { get; set; }

        public Collection()
        {
            Cars = new List<Car>();
        }
    }
}
