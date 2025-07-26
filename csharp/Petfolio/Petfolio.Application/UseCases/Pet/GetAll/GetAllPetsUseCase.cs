using System;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetsJson Execute()
    {
        return new ResponseAllPetsJson
        {
            Pets = new List<ResponseShortsPetJson>
            {
                new ResponseShortsPetJson {
                    Id = 1,
                    Name = "Charlie",
                    Type = Communication.Enums.PetType.Dog
                }
            }
        };
    }
}
