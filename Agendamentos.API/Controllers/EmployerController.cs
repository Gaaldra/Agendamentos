using Agendamentos.API.Database;
using Agendamentos.Biblioteca;
using Microsoft.AspNetCore.Mvc;

namespace Agendamentos.API.Controllers;

[Route("[controller]")]
[ApiController]
public class EmployerController(APIContext context) : ControllerBase
{
    private APIContext _context = context;
    [HttpPost]
    public async Task<IActionResult> CreateFuncionario([FromBody] Client request)
    {
        return Ok(request);
    }
}
