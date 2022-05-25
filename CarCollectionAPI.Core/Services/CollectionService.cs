namespace CarCollectionAPI.Core.Services
{
    using CarCollectionAPI.Core.DTOs;
    using CarCollectionAPI.Core.Interfaces;
    using CarCollectionAPI.Data.Data;
    using CarCollectionAPI.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    public class CollectionService : ICollectionService
    {
        private readonly CarCollectionContext context;

        public CollectionService(CarCollectionContext _context)
        {
            context = _context;
        }

        public async Task<List<Collection>> GetAllCollections()
        {
            var collections = await context.Collections.ToListAsync();
            return collections;
        }

        public async Task<Collection> GetCollectionById(string id)
        {
            var collection = await context.Collections.FirstOrDefaultAsync(c=>c.Id == id);

            if (collection == null)
            {
                return null;
            }

            return collection;
        }

        public async Task<bool> CreateCollection(CollectionCreateDTO model)
        {
            bool isCreated = false;

            if (model == null)
            {
                isCreated = false;
            }

            var collection = new Collection()
            {
                Name = model.Name,
                Description = model.Description,
            };

            try
            {
                await context.AddAsync<Collection>(collection);
                await context.SaveChangesAsync();

                isCreated = true;
            }
            catch (Exception)
            {
                isCreated = false;
            }

            return isCreated;
        }

        
    }
}
