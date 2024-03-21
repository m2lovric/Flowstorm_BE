using Flowstorm_BE.Data;
using Microsoft.AspNetCore.Mvc;

namespace Flowstorm_BE.Controllers;
[Route("api/workspace")]
[ApiController]
public class WorkspaceController : ControllerBase
{
    private readonly ApplicationDBContext _context;
    public WorkspaceController(ApplicationDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var workspaces = _context.Workspace.ToList();

        return Ok(workspaces);
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var workspace = _context.Workspace.Find(id);
        if (workspace == null)
        {
            return NotFound();
        }
        return Ok(workspace);
    }

}