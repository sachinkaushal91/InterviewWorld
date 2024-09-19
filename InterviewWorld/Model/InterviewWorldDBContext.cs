using Microsoft.EntityFrameworkCore;
using System.Data;

namespace InterviewWorld.Model
{
    public class InterviewWorldDBContext : DbContext
    {
        public InterviewWorldDBContext(DbContextOptions<InterviewWorldDBContext> options) : base(options)
        {

        }

        public DbSet<Subject> subjects { get; set; }
    }
}
