using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RetreadWOD.Persistence.Models;

namespace RetreadWOD.Persistence;

public class AppDbContext : IdentityDbContext<ApiUser>
{
    public virtual DbSet<ChatMessage> ChatMessages { get; set; }

    public AppDbContext(
        DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}