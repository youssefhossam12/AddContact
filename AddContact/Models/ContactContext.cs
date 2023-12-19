using Microsoft.EntityFrameworkCore;
using static AddContact.Models.Contact;

namespace AddContact.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options): base(options) 
        {
        
        }
        public DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(

                new Contact
                {
                    ContactId = 1,
                    FirstName = "Jinny",
                    LastName = "Park",
                    Phone = 123456789,
                    Email = "jinny.park@gmail.com",
                    Category = ContactCategory.Family
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Amr",
                    LastName = "Shier",
                    Phone = 987654321,
                    Email = "amr.shier@yahoo.com",
                    Category = ContactCategory.Work
                }, 
                new Contact
                {
                    ContactId = 3,
                    FirstName = "Rawda",
                    LastName = "Emad",
                    Phone = 547354311,
                    Email = "rawda.email@gmail.com",
                    Category = ContactCategory.Friend
                }



                ); 
        }
    }
}
