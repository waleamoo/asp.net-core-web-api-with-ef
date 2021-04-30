using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data 
{
    public class  CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        // the  name of the table to be created by EF
        public DbSet<Command> Commands { get; set; }
    }
}