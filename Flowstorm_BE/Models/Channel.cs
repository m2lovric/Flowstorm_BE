namespace Flowstorm_BE.Models;

public class Channel
{
    public int Id { get; set; }
    public int WorkspaceId { get; set; }
    public string Name { get; set; } = String.Empty;
}