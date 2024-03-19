namespace Flowstorm_BE.Models;

public class Workspace
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public DateTime CreatedAt { get; set; }
    public int OwnerId { get; set; }
}