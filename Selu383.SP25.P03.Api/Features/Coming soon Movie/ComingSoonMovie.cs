using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Selu383.SP25.P03.Api.Features.ComingSoonMovies
{
    [Table("ComingSoonMovies")]
    public class ComingSoonMovie
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
        public int ReleaseYear { get; set; }

        [StringLength(10)]
        public string AgeRating { get; set; }

        public string Poster { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Title} ({ReleaseYear}) - {Genre} | Age Rating: {AgeRating}";
        }

    }

}
﻿
