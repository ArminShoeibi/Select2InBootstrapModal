using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Select2InBootstrapModal.DTOs
{
    public record CreateCategoryDto
    {

        [DisplayName("Parent Category")]
        public int? ParentId { get; init; }

        [Range(1,100)]
        [Required]
        public int DisplayOrder { get; init; }

        [Required]
        [StringLength(40)]
        public string Name { get; init; }

        [StringLength(150)]
        public string Description { get; init; }

        public string BackgroundColor { get; init; }
    }
}
