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
    public void AdicionarFilme([FromBody] Filme filme)
    {
        filme.id = id++;

        filmes.Add(filme);
        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Duracao);

    }

    [HttpGet]
    public IEnumerable<Filme> RecuperarFilme()
    {
        return filmes;
    }

    [HttpGet("{id}")]
    public Filme? RecuperarFilmePorId(int id)
    {
      return filmes.FirstOrDefault(filme => filme.id == id);
    }

}
