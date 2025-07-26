using System;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById;

public class GetPetByIduseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "pipoca",
            Type = Communication.Enums.PetType.Dog,
            Birthday = new DateTime(year: 2023, month: 01, day: 01)
        };
    }
}
