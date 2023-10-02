using System.ComponentModel.DataAnnotations;

namespace PocMvcAPP.Entities
{
    public class Content
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string? Title { get; set; }
        public string? HTMLContent { get; set; }
        public string? VideoLink { get; set; }
        //Establish One to One relationship with the CategoryItem entity
        public virtual CategoryItem? CategoryItems { get; set; }

    }
}
