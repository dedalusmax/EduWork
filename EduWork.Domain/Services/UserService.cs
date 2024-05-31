using EduWork.Common.DTO;
using EduWork.Data;
using EduWork.Data.Entities;
using EduWork.Domain.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EduWork.Domain.Services;

public class UserService(ApplicationDbContext context) : IUserService
{
    public async Task<Profile> GetProfileAsync(int userId)
    {
        var user = await context.Users.FindAsync(userId);

        // TODO...AutoMapper
        var profile = new Profile()
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            RoleName = user.Role.Name
        };

        return profile;
    }

    public async Task UpdateProfileAsync(int userId, Profile profile)
    {
        // TODO...validation of business rules

        var user = new User()
        {
            Id = profile.Id,
            Name = profile.Name,
            Email = profile.Email,
            // Role.Name
        };
        context.Entry(user).State = EntityState.Modified;

        try
        {
            await context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!UserExists(userId))
            {
                throw new KeyNotFoundException("No such record in database.");
            }
            else
            {
                throw;
            }
        }
    }

    private bool UserExists(int id)
    {
        return context.Users.Any(e => e.Id == id);
    }
}
