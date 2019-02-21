using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplicationBlazor.Server.Model;

namespace WebApplicationBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        private List<ToDoItem> toDoItems = new List<ToDoItem>
        {
        };

        [HttpGet("[action]")]
        public IEnumerable<ToDoItem> Items()
        {
            return toDoItems;
        }

        [HttpPost("[action]")]
        public void Items(ToDoItem toDoItem)
        {
            this.toDoItems.Add(toDoItem);
        }

        [HttpDelete("[action]")]
        public void Items(int id)
        {
            toDoItems.Remove(toDoItems.First(x => x.Id == id));
        }
    }
}
