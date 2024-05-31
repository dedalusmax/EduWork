using EduWork.Common.DTO;

namespace EduWork.Domain.Contracts;

public interface IUserService
{
    /// <summary>
    /// Izvuci zbirni prikaz rada po projektima, radne sate (sintetiku unosa radnog vremena), te sintetiku godišnjih odmora i dana bolovanja
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<Profile> GetProfileAsync(int userId);

    /// <summary>
    /// Administrator mora moći mijenati određene podatke zaposlenika, posebice koje se tiču njegove pripadnosti projektu, timske role, vještine te edukacije kroz zasebni modul.
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="profile"></param>
    /// <returns></returns>
    Task UpdateProfileAsync(int userId, Profile profile);
}
