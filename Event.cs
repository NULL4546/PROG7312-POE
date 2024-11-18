namespace PROG7312Lopes
{
    public class Event
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime EventDate { get; set; }
        public string Description { get; set; }

        public Event(string title, string category, DateTime eventDate, string description)
        {
            Title = title;
            Category = category;
            EventDate = eventDate;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Title} - {EventDate.ToShortDateString()} - {Category}";
        }
    }
}
