using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Data
{
    public class StoryContext : DbContext
    {
        public DbSet<Story> Stories { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
