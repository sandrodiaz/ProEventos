using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

public IEnumerable<Evento> _evento = new Evento[]
    {
        new Evento() {
        EventoId = 1,
        Tema = "Angular 11 e .Net 5",
        Local = "Belo Horizonte",
        Lote = "Primeiro",
        QtdPessoas = 10,
        ImagemURL = "www.uol.com.br"
      },
        new Evento() {
        EventoId = 2,
        Tema = "Angular 11 e .Net 5",
        Local = "Belo Horizonte",
        Lote = "Primeiro",
        QtdPessoas = 410,
        ImagemURL = "www.uol.com.br"
      }
    };  

    public EventoController()
    {

    }

    [HttpGet]

    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

       [HttpGet("{id}")]

    public IEnumerable<Evento> Get(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }
    


    [HttpPost]
    public string Post()
    {
        return "valusadalskjdaslkjae";
    }


    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"valusadalskjdaslkjae = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"valusadalskjdaslkjae = {id}";
    }


}
