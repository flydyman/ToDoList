using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoItems;

[Table("todo_item")]
public class ToDoItem
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    public string Description { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool IsDeleted { get; set; } = false;
    [TypeConverter(typeof(int))]
    public ToDoCategory ToDoCategory { get; set; } = ToDoCategory.Projecting;
    [TypeConverter(typeof(int))]
    public ToDoPriority ToDoPriority { get; set; } = ToDoPriority.Normal;
    
    public int CreatorId { get; set; }
    [ForeignKey("CreatorId")]
    public User? Creator { get; set; }
    
    public int AssignedId { get; set; }
    [ForeignKey("AssignedId")]
    public User? Assigned { get; set; }
    
    public int ToDoSubProjectId { get; set; }
    [ForeignKey("ToDoSubProjectId")]
    public ToDoSubProject? ToDoSubProject { get; set; }

    [InverseProperty("CommentedItem")]
    public List<ToDoComment> ToDoComments { get; set; } = new();
}