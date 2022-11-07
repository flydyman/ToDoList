using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoItems;

[Table("user_token")]
public class UserToken
{
    [Key]
    public int Id { get; set; }
    public string Token { get; set; } = "";
    public bool IsActive { get; set; } = true;
    [TypeConverter(typeof(int))]
    public TokenTarget TokenTarget { get; set; } = TokenTarget.Email;
    
    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User? User { get; set; }
    
    
}