using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SqliteGenerationAPI.Datas;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SqliteGenerationAPI.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        private readonly DataContext _dbContext;

        public DataController(DataContext dbContext)
        {
            _dbContext = dbContext;
            if (_dbContext.TodoItems.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _dbContext.TodoItems.Add(new TodoItem { Name = "Item1" });
                _dbContext.SaveChanges();
            }
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            return await _dbContext.TodoItems.ToListAsync();
        }

        [HttpGet("GenerateSqlite")]
        public string GenerateSqlite()
        {
            return "value";
        }
    }
}
