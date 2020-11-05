using ToDoItems;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ToDoItemApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToDoItemsController : ControllerBase
    {
        private MemoryRepository _repository = MemoryRepository.Instance;

        [HttpGet]
        public async Task<ActionResult<List<ToDoItem>>> QueryAsync()
        {
            var models = await _repository.QueryAsync();
            return Ok(models);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<ToDoItem>>> GetAsync(
            long id)
        {
            var list = await _repository.GetAsync(id);
            return Ok(list);
        }
    }
}
