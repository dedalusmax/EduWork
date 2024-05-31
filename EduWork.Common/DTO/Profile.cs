namespace EduWork.Common.DTO;

public record Profile
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string RoleName { get; set; }

    // ...
}
