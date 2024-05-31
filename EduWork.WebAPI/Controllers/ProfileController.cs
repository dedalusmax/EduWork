using EduWork.Common.DTO;
using EduWork.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EduWork.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProfileController(IUserService service) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<Profile>> GetProfileAsync(int userId)
    {
        try
        {
            var result = await service.GetProfileAsync(userId);
            return result;
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound();
        }
    }

    [HttpPut]
    public async Task UpdateProfileAsync(int userId, Profile profile)
    {
        try
        {
            var result = await service.GetProfileAsync(userId);
        }
        catch (KeyNotFoundException ex)
        {

        }
    }
}
