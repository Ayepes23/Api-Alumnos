using Microsoft.EntityFrameworkCore;
using MyApi.Models;

namespace MyApi.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public DbSet<Alumnos> Alumnos { get; set; } = null!;
}