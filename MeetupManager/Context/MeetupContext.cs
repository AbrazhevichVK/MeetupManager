using MeetupManager.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetupManager.Context
{
    public class MeetupContext : DbContext
    {
        public MeetupContext(DbContextOptions<MeetupContext> options) : base(options)
        {
            
        }

        public DbSet<Meetup> Meetups { get; set; }
    }
}
