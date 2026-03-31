using GuardianEye.Core.Entities;

namespace GuardianEye.Core.Interfaces;

public interface IPersonRepository
{
    Task AddAsync(Person person);
    Task<Person?> GetByIdAsync(Guid id);
}