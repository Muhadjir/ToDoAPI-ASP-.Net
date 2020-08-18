using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Models;

namespace ToDoAPI.Data
{
    //todo context
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        
        public DbSet<ToDo> ToDos { get; set; }
    }
}
