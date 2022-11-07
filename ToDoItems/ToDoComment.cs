using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoItems;

[Table("todo_comment")]
public class ToDoComment
{
    [Key]
    public int Id { get; set; }
    public string Text { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool IsDeleted { get; set; } = false;
    
    public int CreatorId { get; set; }
    [Required]
    [ForeignKey("CreatorId")]
    public User Creator { get; set; }
    
    public int ItemId { get; set; }
    [Required]
    [ForeignKey("ItemId")]
    public ToDoItem CommentedItem { get; set; }
}