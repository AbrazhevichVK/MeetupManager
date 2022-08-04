using Storage.Models;
using Microsoft.EntityFrameworkCore;

namespace Storage.Context
{
    public class MeetupContext : DbContext
    {
        public MeetupContext(DbContextOptions<MeetupContext> options) : base(options)
        {
            
        }

        public DbSet<MeetupDataModel> Meetups { get; set; }
    }
}
