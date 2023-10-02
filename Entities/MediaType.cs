using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PocMvcAPP.Entities
{
    public class MediaType
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string? Title { get; set; }
        [Required]
        public string? ThumbnailImagePath { get; set; }
        //Establish the referential integrity between the CategoryItem and the MediaType Entity
        [ForeignKey("MediaTypeId")]
        public virtual ICollection<CategoryItem>? CategoryItems { get; set; }
    }
}
