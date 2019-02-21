﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplicationBlazor.Shared;
using System.Threading.Tasks;

namespace WebApplicationBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        static List<ToDoItem> toDoItems = new List<ToDoItem>
        {
            new ToDoItem(){ Id = 1, Title = "Analyze story", Description="Do structural analysis of user story 1"}
        };

        [HttpGet("[action]")]
        public IEnumerable<ToDoItem> Items()
        {
            return toDoItems;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ToDoItem>> Items([FromBody] ToDoItem toDoItem)
        {
            toDoItems.Add(toDoItem);

            return CreatedAtAction("Items post", toDoItem);
        }

        [HttpDelete("[action]")]
        public void Items(int id)
        {
            toDoItems.Remove(toDoItems.First(x => x.Id == id));
        }
    }
}