using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduWork.Data.Entities;

[Table("Users")]
public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [EmailAddress, Required]
    public string Email { get; set; }

    [Required]
    public Guid RoleId { get; set; }

    [Required]
    public virtual Role Role { get; set; }
}
