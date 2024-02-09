using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstRESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly List<TodoItem> _todoItems;

        public TodoController()
        {
            ///add some sample data
            _todoItems = new List<TodoItem>
            {
                new TodoItem{ Id=1,Title="Learn to communicate", Completed=true},
                new TodoItem{Id=2,Title="Alchemist",Completed=false}
            };
        }

        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> Get()
        {
            return Ok(_todoItems);
        }
    }
}
