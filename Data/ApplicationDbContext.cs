using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PocMvcAPP.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocMvcAPP.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string? LastName { get; set;}
        [ForeignKey("UserId")]
        public virtual ICollection<UserCategory>? UserCategory { get;}
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Tell EF to create the tables
        //I need to make Category public so I can use in the new area ADMIN
        public DbSet<Category>? Category { get; set; }
        public DbSet<CategoryItem>? CategoryItem { get; set; }
        DbSet<Content>? Content { get; set; }
        DbSet<MediaType>? MediaType { get; set; }
        DbSet<UserCategory>? UserCategory { get; set; }
    }
}