using Microsoft.EntityFrameworkCore;
namespace TodoAppApi;
public class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options)
    {
    }

    public DbSet<Todo> Todos => this.Set<Todo>();
}
