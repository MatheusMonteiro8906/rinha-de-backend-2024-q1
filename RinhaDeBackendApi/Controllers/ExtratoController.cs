using RinhaDeBackendApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace RinhaDeBackendApi.Controllers;


[ApiController]
[Route("clientes")]
public class ExtratoController : ControllerBase
{

    [HttpGet("{id}/extrato")]
    public ActionResult BuscarExtrato([FromBody] Transacao transacao)
    {
        return Ok("Extrato encontrado com sucesso.");
    }

}
