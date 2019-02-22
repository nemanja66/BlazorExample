using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplicationBlazor.Shared;

namespace WebApplicationBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        static List<ToDoItem> toDoItems = new List<ToDoItem>
        {
            new ToDoItem(){ Id = 1, Title = "Analyze story", Description="Do structural analysis of user story 1", Hours = 3}
        };

        [HttpGet("[action]")]
        public IEnumerable<ToDoItem> Items()
        {
            return toDoItems;
        }

        [HttpPost("[action]")]
        public ActionResult<ToDoItem> Items([FromBody] ToDoItem toDoItem)
        {
            if (toDoItem.IsValid() != string.Empty)
                return BadRequest(toDoItem);

            var currentId = toDoItems.Any() ? toDoItems.Max(x => x.Id) : 0;
            toDoItem.Id = currentId + 1;
            toDoItems.Add(toDoItem);

            return Ok(toDoItem);
        }

        [HttpDelete("[action]/{id}")]
        public ActionResult Items(int id)
        {
            try
            {
                toDoItems.Remove(toDoItems.First(x => x.Id == id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return Ok();
        }
    }
}
