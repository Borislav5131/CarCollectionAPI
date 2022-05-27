namespace CarCollectionAPI.Controllers
{
    using CarCollectionAPI.Core.DTOs;
    using CarCollectionAPI.Core.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CollectionController : ControllerBase
    {
        private readonly ICollectionService collectionService;

        public CollectionController(ICollectionService _collectionService)
        {
            collectionService = _collectionService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var collections = await collectionService.GetAllCollections();

            return Ok(collections);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(string id)
        {
            var collection = await collectionService.GetCollectionById(id);

            if (collection == null)
            {
                return BadRequest();
            }

            return Ok(collection);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CollectionCreateDTO model)
        {
            var created = await collectionService.CreateCollection(model);

            if (!created)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> Edit(string id, CollectionEditDTO model)
        {
            var editCollection = await collectionService.EditCollection(id, model);

            if (editCollection == null)
            {
                return BadRequest();
            }

            return Ok(editCollection);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(string id)
        {
            var isDeleted = await collectionService.DeleteCollection(id);

            if (!isDeleted)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
