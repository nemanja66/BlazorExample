using System;

namespace WebApplicationBlazor.Shared
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; private set; }

        private int hours;
        public int Hours
        {
            get { return hours; }
            set
            {
                hours = value;
                DueDate = DateTime.Now.AddHours(hours);
            }
        }
    }
}
