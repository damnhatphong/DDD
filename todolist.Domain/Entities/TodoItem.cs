using TodoList.Domain.ValueObject;

namespace TodoList.Domain.Entities
{
    public class TodoItem
    {
        public required int Id { get; set; } // Integer ID, another option is GUID v7, read more on in this thread: https://dba.stackexchange.com/questions/264/guid-vs-int-which-is-better-as-a-primary-key
        public required string Title { get; set; } // This can not be the domain entity key because Title can be duplicate
        public string? Content { get; set; }
        public ItemDescription? Description { get; set; }
        public Metadata? Metadata { get; set; }
    }
}
