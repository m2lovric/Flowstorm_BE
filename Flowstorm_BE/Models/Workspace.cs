namespace Flowstorm_BE.Models;

public class Workspace
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public int OwnerId { get; set; }
    public DateTime CreatedAt { get; set; }
}