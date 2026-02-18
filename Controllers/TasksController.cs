using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;

namespace TaskApi.Controllers;

[ApiController]
[Route("tasks")]
public class TasksController : ControllerBase
{
    private static readonly List<TaskItem> Tasks = new();
    private static int _nextId = 1;

    [HttpGet]
    public ActionResult<List<TaskItem>> GetAll()
        => Ok(Tasks.OrderByDescending(t => t.Id));

    [HttpGet("{id:int}")]
    public ActionResult<TaskItem> GetById(int id)
    {
        var task = Tasks.FirstOrDefault(t => t.Id == id);
        return task is null ? NotFound() : Ok(task);
    }

    public record CreateTaskDto(string Title, string? Description);
    public record UpdateTaskDto(string Title, string? Description, bool IsDone);

    [HttpPost]
    public ActionResult<TaskItem> Create([FromBody] CreateTaskDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Title))
            return BadRequest("Title é obrigatório.");

        var task = new TaskItem
        {
            Id = _nextId++,
            Title = dto.Title.Trim(),
            Description = dto.Description
        };

        Tasks.Add(task);
        return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
    }

    [HttpPut("{id:int}")]
    public ActionResult<TaskItem> Update(int id, [FromBody] UpdateTaskDto dto)
    {
        var task = Tasks.FirstOrDefault(t => t.Id == id);
        if (task is null) return NotFound();

        if (string.IsNullOrWhiteSpace(dto.Title))
            return BadRequest("Title é obrigatório.");

        task.Title = dto.Title.Trim();
        task.Description = dto.Description;
        task.IsDone = dto.IsDone;

        return Ok(task);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var task = Tasks.FirstOrDefault(t => t.Id == id);
        if (task is null) return NotFound();

        Tasks.Remove(task);
        return NoContent();
    }
}
        Tasks.Remove(task);
        return NoContent();
    }
}
