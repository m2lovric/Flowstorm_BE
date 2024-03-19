namespace Flowstorm_BE.Models;

public class Message
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; } = String.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public int ChannelId { get; set; }
    public Channel Channel { get; set; }
}