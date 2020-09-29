using OPAC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace OPAC.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {

        }

        //User
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Application> Application { get; set; }
        public DbSet<Form> Form { get; set; }
 
        //Book
        public DbSet<Book> Books { get; set; }
        public DbSet<BookTransaction> BookTransaction { get; set; }
        public DbSet<BookReview> BookReview { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<BookTag> BookTags { get; set; }
        public DbSet<BookLearn> BookLearns { get; set; }
        public DbSet<BookRequirement> BookRequirements { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BookActivity> BookActivities { get; set; }

        //Author
        public DbSet<Author> Author { get; set; }
        public DbSet<AuthorContact> AuthorContacts { get; set; }
        public DbSet<ContactLabel> ContactLabels { get; set; }
    }
}