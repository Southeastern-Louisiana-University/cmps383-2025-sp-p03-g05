using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Selu383.SP25.P03.Api.Features.Movies
   
{
        using System.ComponentModel.DataAnnotations;
[Table("Movies")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Genre { get; set; }

        [Required]
        [Range(1900, 2100)]
        public int Year { get; set; }

        [Required]
        [StringLength(10)]
        public string AgeRating { get; set; } // G, PG, PG-13, R

        public string Poster { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Title} ({Year}) - {Genre} | Age Rating: {AgeRating}";
        }
    }





















}

