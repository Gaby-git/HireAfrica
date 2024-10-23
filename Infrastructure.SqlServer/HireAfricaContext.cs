namespace Infrastructure.SqlServer;

using Infrastructure.SqlServer.Entities;
using Microsoft.EntityFrameworkCore;

public class HireAfricaContext : DbContext
{
    public HireAfricaContext(DbContextOptions<HireAfricaContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<JobListing> JobListings { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<Resume> Resumes { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<CompanyReview> CompanyReviews { get; set; }
    public DbSet<Interview> Interviews { get; set; }
    public DbSet<Notification> Notifications { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Applications)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Company>()
                .HasMany(c => c.Applications)
                .WithOne(a => a.Company)
                .HasForeignKey(a => a.CompanyId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Company>()
                .HasMany(c => c.JobListings)
                .WithOne(j => j.Company)
                .HasForeignKey(j => j.CompanyId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<JobListing>()
                .HasOne(j => j.Quiz)
                .WithOne(q => q.JobListing)
                .HasForeignKey<Quiz>(q => q.JobListingId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Quiz>()
                .HasMany(q => q.Questions)
                .WithOne(qu => qu.Quiz)
                .HasForeignKey(qu => qu.QuizId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<JobListing>()
                .HasMany(i => i.Interviews)
                .WithOne(q => q.JobListing)
                .HasForeignKey(q => q.JobListingId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Question>()
                .HasMany(q => q.Answers)
                .WithOne(a => a.Question)
                .HasForeignKey(a => a.QuestionId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<User>()
                .HasMany(u => u.Answers)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<User>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Company>()
                .HasMany(c => c.Reviews)
                .WithOne(r => r.Company)
                .HasForeignKey(r => r.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Resume)
                .WithOne(r => r.User)
                .HasForeignKey<Resume>(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<User>()
                .HasOne(u => u.Portfolio)
                .WithOne(p => p.User)
                .HasForeignKey<Portfolio>(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Application>()
                .HasMany(a => a.Interview)
                .WithOne(i => i.Application)
                .HasForeignKey(i => i.ApplicationId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<User>()
                .HasMany(u => u.Notifications)
                .WithOne(n => n.User)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<JobListing>()
               .HasOne(j => j.Application)
               .WithMany(a => a.JobListings)
               .HasForeignKey(j => j.AppicationId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<JobListing>()
               .HasOne(j => j.Company)
               .WithMany(c => c.JobListings)
               .HasForeignKey(j => j.CompanyId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}