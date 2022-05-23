namespace CarCollectionAPI.Core.Interfaces
{
    using CarCollectionAPI.Data.Models;

    public interface ICollectionService
    {
        public bool CreateCollection(Collection model);
    }
}
