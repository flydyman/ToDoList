using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoItems;

[Table("todo_subproject")]
public class ToDoSubProject
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool IsDeleted { get; set; } = false;

    [TypeConverter(typeof(int))]
    public ToDoCategory ToDoCategory { get; set; } = ToDoCategory.Projecting;
    [TypeConverter(typeof(int))]
    public ToDoPriority ToDoPriority { get; set; } = ToDoPriority.Normal;
    
    public int ToDoProjectId { get; set; }
    [ForeignKey("ToDoProjectId")]
    public ToDoProject? ToDoProject { get; set; }
    
    public int CreatorId { get; set; }
    [ForeignKey("CreatorId")]
    public User? Creator { get; set; }
    
    public int MaintainerId { get; set; }
    [ForeignKey("MaintainerId")]
    public User? Maintainer { get; set; }

    [InverseProperty("ToDoSubProject")]
    public List<ToDoItem> ToDoItems { get; set; } = new();
}