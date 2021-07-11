using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Character> Character { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SkillSet> SkillSet { get; set; }

        public DbSet<Lesson> Lessons { get; set; }
    }
}
