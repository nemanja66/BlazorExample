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
        public string IsValid()
        {
            if (string.IsNullOrEmpty(Title))
                return "Title";
            else if (string.IsNullOrEmpty(Description))
                return "Description";
            else if (hours <= 0)
                return "Hours";
            else return string.Empty;
        }
    }
}
