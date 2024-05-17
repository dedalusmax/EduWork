using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduWork.Data.Entities;

[Table("Roles")]
public class Role
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    public virtual ICollection<User> Users { get; set; }
}
