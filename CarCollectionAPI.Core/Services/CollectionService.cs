namespace CarCollectionAPI.Core.Services
{
    using CarCollectionAPI.Core.Interfaces;
    using CarCollectionAPI.Data.Data;
    using CarCollectionAPI.Data.Models;

    public class CollectionService : ICollectionService
    {
        private readonly CarCollectionContext context;

        public CollectionService(CarCollectionContext _context)
        {
            context = _context;
        }

        public bool CreateCollection(Collection model)
        {
            bool isCreated = false;

            if (model == null)
            {
                isCreated = false;
            }

            try
            {
                context.Add<Collection>(model);
                context.SaveChanges();

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
