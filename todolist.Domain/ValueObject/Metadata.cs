namespace TodoList.Domain.ValueObject
{
    public class Metadata
    {
        public string Author { get; set; } = string.Empty;
        // Datetime vs DatetimeOffset https://stackoverflow.com/questions/4331189/datetime-vs-datetimeoffset
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
