using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ToDoItems;

public class ToDoContext: DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<UserGroup> UserGroups => Set<UserGroup>();
    public DbSet<UserToken> UserTokens => Set<UserToken>();
    public DbSet<ToDoComment> ToDoComments => Set<ToDoComment>();
    public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();
    public DbSet<ToDoProject> ToDoProjects => Set<ToDoProject>();
    public DbSet<ToDoSubProject> ToDoSubProjects => Set<ToDoSubProject>();

    public ToDoContext(DbContextOptions<ToDoContext> options): base (options)
    {
        Database.EnsureCreated();
    }

}