using Microsoft.EntityFrameworkCore;
using System;
using WebAgenda.Data.Mappings;
using WebAgenda.Domain.Entities;

namespace WebAgenda.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ContactMap());
            base.OnModelCreating(builder);
        }
    }
}
