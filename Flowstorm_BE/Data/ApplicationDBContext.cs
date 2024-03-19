using Flowstorm_BE.Models;
using Microsoft.EntityFrameworkCore;

namespace Flowstorm_BE.Data;

public class ApplicationDBContext: DbContext
{
    public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    }
    
    public DbSet<Channel> Channel { get; set; }
    public DbSet<Workspace> Workspace { get; set; }
    public DbSet<Message> Message { get; set; }
}