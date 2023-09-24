namespace TodoAppApi;

#pragma warning disable S101
public class TodoItemDTO
#pragma warning restore S101
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }

#pragma warning disable SA1201
    public TodoItemDTO()
#pragma warning restore SA1201
    {
    }

    public TodoItemDTO(Todo todoItem) =>
    (this.Id, this.Name, this.IsComplete) = (todoItem.Id, todoItem.Name, todoItem.IsComplete);
}
