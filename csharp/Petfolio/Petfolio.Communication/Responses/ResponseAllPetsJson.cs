using System;

namespace Petfolio.Communication.Responses;

public class ResponseAllPetsJson
{
    public List<ResponseShortsPetJson> Pets { get; set; } = [];
}
