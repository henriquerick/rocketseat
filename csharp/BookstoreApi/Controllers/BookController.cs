using BookstoreApi.Communication.Requests;
using BookstoreApi.Communication.Responses;
using BookstoreApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponseRegisterBookJson
        {
            Id = 1,
            Title = request.Title
        };

        return Created(string.Empty, response);
    }

}

