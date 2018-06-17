using IntegratedLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace IntegratedLibrary
{
    public class IntegratedLibraryContext : DbContext
    {
        public IntegratedLibraryContext(DbContextOptions<IntegratedLibraryContext> options) : base(options)
        {
        }

        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BranchHours> BranchHourses { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<CheckoutHistory> CheckoutHistories { get; set; }
        public DbSet<Hold> Holds { get; set; }
        public DbSet<LibraryAsset> LibraryAssets { get; set; }
        public DbSet<LibraryBranch> LibraryBranchs { get; set; }
        public DbSet<LibraryCard> LibraryCards { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Video> Videoes { get; set; }
    }
}
