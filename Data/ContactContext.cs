using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactManagement.Models;

namespace ContactManagement.Data
{
    public class ContactContext : DbContext
    {
        public ContactContext (DbContextOptions<ContactContext> options)
            : base(options)
        {
        }
       
        public DbSet<Contact> Contact { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contact");
        }
        
        
        //public DbSet<ContactManagement.Models.Contact> Contact { get; set; }
        
    }
}
