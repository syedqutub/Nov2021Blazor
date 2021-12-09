using System.ComponentModel.DataAnnotations;

namespace BlazorTodoNet6.Shared;

public class Todo
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    public bool IsCompleted { get; set; }
}