using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RetreadWOD.Persistence.Models;

namespace RetreadWOD.Persistence;

public class AppDbContext : IdentityDbContext<ApiUser>
{
}