using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;

namespace PhoneBook
{
    public class PhoneBookContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= DESKTOP-4BRHCUT\\SQLEXPRESS;database=PhoneBook;Trusted_Connection = true;TrustServerCertificate=true;");
        }
    }

}
