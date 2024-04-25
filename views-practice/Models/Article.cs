using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace views_practice.Models
{
    public class Article
    {
        [Key]
        public int         Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Title")]
        public string       Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string       Description { get; set; }
        [Required]
        public User         Author { get; set; }
        [Required]
        public DateOnly     DateOfCreation { get; set; }
        [Required]
        public string       ImgUrl { get; set; }
        [Required]
        public string       Content { get; set; }
        public List<string> Tages { get; set; }

    }
}
