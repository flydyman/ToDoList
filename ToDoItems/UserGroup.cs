using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoItems;

[Table("user_group")]
public class UserGroup
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }

    [InverseProperty("UserGroup")]
    public List<User> Users { get; set; } = new();
}