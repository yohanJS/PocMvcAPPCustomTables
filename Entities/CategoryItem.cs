using System.ComponentModel.DataAnnotations;

namespace PocMvcAPP.Entities
{
    public class CategoryItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string? Title { get; set; }
        //Represents the foregin key for the Category Entity
        public int CategoryId { get; set; }
        //Represents the foregin key for the MediaType Entity
        public int MediaTypeId { get; set; }
        public DateTime? DateTimeReleased { get; set; } = default(DateTime?);

    }
}
