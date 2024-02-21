using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;


[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 0;

    [HttpPost]
    public ActionResult AdicionarFilme([FromBody] Filme filme)
    {
        filme.Id = id++;

        filmes.Add(filme);

        return Ok("Filme adicionado com sucesso");
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Filme>), statusCode:200)]
    [ProducesResponseType(statusCode:204)]
    public ActionResult<IEnumerable<Filme>> BuscarFilmes()
    {
        if(filmes.Count >= 1){
        return Ok(filmes);
        }
        else
        {
        return NoContent();
        }
    }

    [ProducesResponseType(typeof(IEnumerable<Filme>), statusCode: 200)]
    [ProducesResponseType(statusCode: 400)]
    [HttpGet("{id}")]
    public ActionResult<Filme?> BuscarFilmePorId(int id)
    {
        if (filmes.FirstOrDefault(filme => filme.Id == id) != null)
        {
            return Ok(filmes.FirstOrDefault(filme => filme.Id == id));
        }
        else
        {
            return BadRequest("O id requisitado não existe.");
        }
    }


    [ProducesResponseType(typeof(IEnumerable<Filme>), statusCode: 200)]
    [ProducesResponseType(statusCode: 400)]
    [HttpDelete("{id}")]
    public ActionResult<Filme?> ApagarFilmePorId(int id)
    {

        var movieToRemove = filmes.FirstOrDefault(filme => filme.Id == id);
     
        if (movieToRemove != null)
        {
            filmes.Remove(movieToRemove);
            return Ok("Filme apagado com sucesso");
        }
        else
        {
            return NotFound("O id requisitado não existe.");
        }

    }


    [ProducesResponseType(typeof(IEnumerable<Filme>), statusCode: 200)]
    [ProducesResponseType(statusCode: 400)]
    [HttpPut("{id}")]
    public ActionResult<Filme?> EditarFilmePorId(int id, [FromBody] Filme filme)
    {
        var movieToEdit = filmes.FirstOrDefault(filme => filme.Id == id);
        
        if(movieToEdit != null)
        {
            movieToEdit.Titulo = filme.Titulo;
            movieToEdit.Duracao = filme.Duracao;
            movieToEdit.Genero = filme.Genero;

            return Ok("Filme editado com sucesso.");
        } 
        else
        {
            return BadRequest("Ocorreu algum problema ao realizar a requisição.");
        }
    }
}
