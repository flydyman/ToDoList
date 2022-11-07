using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoItems;

[Table("user")]
public class User
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Password { get; set; }
    public bool IsDeleted { get; set; } = false;
    public string Email { get; set; } = "";
    public bool IsActive { get; set; } = false;
    
    public int UserGroupId { get; set; }
    [ForeignKey("UserGroupId")]
    public UserGroup? UserGroup { get; set; }

    // ToDoItem
    [InverseProperty("Assigned")]
    public List<ToDoItem> ToDoItemsAssigned { get; set; } = new();
    [InverseProperty("Creator")]
    public List<ToDoItem> ToDoItemsCreated { get; set; } = new();
    
    // ToDoProject
    [InverseProperty("Creator")]
    public List<ToDoProject> ToDoProjectsAsCreator { get; set; } = new();
    [InverseProperty("Maintainer")]
    public List<ToDoProject> ToDoProjectMaintainer { get; set; } = new();
    
    // ToDoSubProject
    [InverseProperty("Creator")]
    public List<ToDoSubProject> ToDoSubProjectsAsCreator { get; set; } = new();
    [InverseProperty("Maintainer")]
    public List<ToDoSubProject> ToDoSubProjectMaintainer { get; set; } = new();

    [InverseProperty("Creator")]
    public List<ToDoComment> ToDoComments { get; set; } = new();

    [InverseProperty("User")]
    public List<UserToken> UserTokens { get; set; } = new();
}