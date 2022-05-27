namespace CarCollectionAPI.Core.Interfaces
{
    using CarCollectionAPI.Core.DTOs;
    using CarCollectionAPI.Data.Models;

    public interface ICollectionService
    {
        public Task<List<Collection>> GetAllCollections();

        public Task<bool> CreateCollection(CollectionCreateDTO model);

        public Task<Collection> GetCollectionById(string id);
        public Task<bool> DeleteCollection(string id);
        public Task<Collection> EditCollection(string id, CollectionEditDTO model);
    }
}
