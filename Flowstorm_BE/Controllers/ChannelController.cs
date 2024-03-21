using Flowstorm_BE.Data;
using Microsoft.AspNetCore.Mvc;
namespace Flowstorm_BE.Controllers;

[Route("api/channel")]
[ApiController]
public class ChannelController : ControllerBase
{
    private readonly ApplicationDBContext _context;
    public ChannelController(ApplicationDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var channels = _context.Channel.ToList();

        return Ok(channels);
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var channel = _context.Channel.Find(id);
        if (channel == null)
        {
            return NotFound();
        }
        return Ok(channel);
    }

}