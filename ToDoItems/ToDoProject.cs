using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoItems;

[Table("todo_project")]
public class ToDoProject
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool IsDeleted { get; set; } = false;
    
    public int CreatorId { get; set; }
    [ForeignKey("CreatorId")]
    public User? Creator { get; set; }

    [TypeConverter(typeof(int))]
    public ToDoCategory ToDoCategory { get; set; } = ToDoCategory.Projecting;
    [TypeConverter(typeof(int))]
    public ToDoPriority ToDoPriority { get; set; } = ToDoPriority.Normal;
    
    public int MaintainerId { get; set; }
    [ForeignKey("MaintainerId")]
    public User? Maintainer { get; set; }

    public List<ToDoSubProject> ToDoSubProjects { get; set; } = new();
}