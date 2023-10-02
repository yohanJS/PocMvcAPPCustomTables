using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocMvcAPP.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string? Title { get; set; }
        public string? Description { get; set; }
        [Required]
        public string? ThumbnailImagePath { get; set; }
        //Establish the referential integrity between the Category and the CategoryItem Entity
        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem>? CategoryItems { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory>? UserCategory { get; set; }
    }
}
