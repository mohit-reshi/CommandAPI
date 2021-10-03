using commandapi.Models;
using Microsoft.EntityFrameworkCore;


namespace commandapi.Data
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options):base(options)
        {

        }
        
        public DbSet <Command> CommandItems {get; set;}
    }
}