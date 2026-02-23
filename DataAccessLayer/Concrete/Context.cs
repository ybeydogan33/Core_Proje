using EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=CoreProjeDB.db");
    }
    public DbSet<About> Abouts{get; set;}
    public DbSet<Contact> Contacts{get; set;}
    public DbSet<Experience> Experiences{get; set;}
    public DbSet<Feature> Features{get; set;}
    public DbSet<Message> Messages{get; set;}
    public DbSet<Portfolio> Portfolios{get; set;}
    public DbSet<Service> Services{get; set;}
    public DbSet<Skill> Skills{get; set;} 
    public DbSet<SocialMedia> SocialMedias{get; set;}
    public DbSet<Testimonial> Testimonials{get; set;}   
}
