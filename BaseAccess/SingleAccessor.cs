using ToDoItems;

namespace BaseAccess;

public static class SingleAccessor
{
    private static ToDoContext _db = new ToDoContext(null);
    public static ToDoContext Db
    {
        get => _db;
    }
}