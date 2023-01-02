namespace Fantastan.Controllers;

using Fantastan.Models;
using Fantastan.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class EventController : ControllerBase
{
    public EventController()
    {}
    
    [HttpGet]
    public ActionResult<List<Event>> GetAll() =>
        EventService.GetAll();
    
    [HttpGet("{id}")]
    public ActionResult<Event> FindEvent(int id)
    {
        var ev = EventService.Get(id);

        if (ev is null) return NotFound();
        return ev;
    }
}