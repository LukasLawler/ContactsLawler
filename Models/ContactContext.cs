using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContactsLawler.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Fred Durst",
                    Number = 4832982995,
                    Address = "438 Limp Ave, Los Angeles, CA 90001",
                    Note = "Limp Bizkit"
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Misha Mansoor",
                    Number = 8003400034,
                    Address = "6430 Bulb Ave, Bethesda, Maryland 20810",
                    Note = "Guitar player"
                },
                new Contact
                {
                    ContactId = 3,
                    Name = "Lukas Lawler",
                    Number = 7127924154,
                    Address = "618 E 18th St, Carroll, IA 51401",
                    Note = "Hey, that's me! Not real info though."
                }
            );
        }
    }
}
