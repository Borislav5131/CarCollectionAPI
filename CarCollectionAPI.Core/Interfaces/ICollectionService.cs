namespace CarCollectionAPI.Core.Interfaces
{
    using CarCollectionAPI.Core.DTOs;
    using CarCollectionAPI.Data.Models;

    public interface ICollectionService
    {
        public Task<List<Collection>> GetAllCollections();

        public Task<bool> CreateCollection(CollectionCreateDTO model);

        public Task<Collection> GetCollectionById(string id);
    }
}
