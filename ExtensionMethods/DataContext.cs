using System;
using Microsoft.EntityFrameworkCore;

namespace ExtensionMethods
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Agenda> Agendamento { get; set; }
    }
}