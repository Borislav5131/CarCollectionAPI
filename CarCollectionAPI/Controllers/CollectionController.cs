namespace CarCollectionAPI.Controllers
{
    using CarCollectionAPI.Core.Interfaces;
    using CarCollectionAPI.Data.Models;
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
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("GetById")]
        public string GetById(int id)
        {
            return "value";
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(Collection model)
        {
            var created = collectionService.CreateCollection(model);

            if (!created)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut("Edit")]
        public void Edit(int id, [FromBody] string value)
        {
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
        }
    }
}
