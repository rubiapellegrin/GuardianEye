using GuardianEye.Application.DTO;

namespace GuardianEye.Application.Interfaces
{
    public interface IPersonService
    {
        Task<Guid> CreatePersonAsync(CreatePersonRequest request);
    }
}
