using BlazorTodoNet6.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorTodoNet6.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    public static List<Todo> todos = new List<Todo>();

    [HttpGet]
    public List<Todo> Get()
        => todos;

    [HttpPost]
    public Todo Post([FromBody]Todo todo)
    {
        todo.Id = Environment.TickCount;
        todos.Add(todo);
        return todo;
    }
}
