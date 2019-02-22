namespace WebApplicationBlazor.Shared
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IsValid()
        {
            if (string.IsNullOrEmpty(Title))
                return "Title";
            else if (string.IsNullOrEmpty(Description))
                return "Description";
            else return string.Empty;
        }
    }
}
