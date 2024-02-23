using RinhaDeBackendApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace RinhaDeBackendApi.Controllers;


[ApiController]
[Route("clientes")]
public class TransacoesController : ControllerBase
{

    [HttpPost("{id}/transacoes")]
    public ActionResult RealizarTransacao([FromBody] Transacao transacao)
    {
        return Ok("Transação realizada com sucesso.");
    }

}
