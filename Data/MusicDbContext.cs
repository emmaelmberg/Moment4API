using Microsoft.EntityFrameworkCore;
using Moment4API.Models;
namespace Moment4API.Data;

public class MusicDbContext : DbContext {
public MusicDbContext(DbContextOptions<MusicDbContext>
options) : base(options) { }
public DbSet<Song> Songs { get; set; }
}