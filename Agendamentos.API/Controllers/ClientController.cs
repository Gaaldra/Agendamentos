using Agendamentos.API.Database;
using Agendamentos.Biblioteca;
using Microsoft.AspNetCore.Mvc;

namespace Agendamentos.API.Controllers;

[Route("[controller]")] // Anotação
[ApiController]
public class ClientController(APIContext context) : ControllerBase
{
    private APIContext _context = context;

    [HttpPost]
    public IActionResult RegisterClient([FromBody] Client request)
    {
        return Created();
    }

    [HttpGet("{id}")]
    public IActionResult GetClientByID(int id)
    {
        return Ok(new
        {
            Message = id
        });
    }
}
