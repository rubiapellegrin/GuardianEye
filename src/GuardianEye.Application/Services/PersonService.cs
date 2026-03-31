using GuardianEye.Application.DTO;
using GuardianEye.Application.Interfaces;
using GuardianEye.Core.Entities;
using GuardianEye.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuardianEye.Application.Services;

public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public async Task<Guid> CreatePersonAsync(CreatePersonRequest request)
    {
        var person = new Person
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            CreatedAt = DateTime.UtcNow,
            IsActive = true
        };

        await _personRepository.AddAsync(person);

        return person.Id;
    }
}