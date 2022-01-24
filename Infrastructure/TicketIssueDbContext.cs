using Microsoft.EntityFrameworkCore;
using TicketManagementSystem.Models;
namespace TicketManagementSystem.Infrastructure
{
    public class TicketIssueDbContext: DbContext
    {
        public TicketIssueDbContext(DbContextOptions options):base (options)
        {

        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<IssueMaster> IssueMasters { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Operators> Operator { get; set; }
        public DbSet<Roles> Role { get; set; }
        public DbSet<Tickets> Ticket { get; set; } 
        public DbSet<TrackStatus> TrackStatuses { get; set; }
        public DbSet<Users> User { get; set; }
       
    }
}