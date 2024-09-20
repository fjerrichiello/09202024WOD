using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RetreadWOD.Persistence.Models;

namespace RetreadWOD.Persistence;

public class AppDbContext : IdentityDbContext<ApiUser>
{
    public AppDbContext(
        DbContextOptions options) : base(options)
    {
    }
}