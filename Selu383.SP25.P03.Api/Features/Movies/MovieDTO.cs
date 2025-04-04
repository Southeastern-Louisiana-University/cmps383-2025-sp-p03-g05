using Microsoft.AspNetCore.Mvc;

namespace Selu383.SP25.P03.Api.Features.Movies
{

    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string AgeRating { get; set; }
        public string Poster { get; set; }
    }

    public class GetMovieDto
    {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Genre { get; set; }
            public int Year { get; set; }
            public string AgeRating { get; set; }
            public string Poster { get; set; }
    }

        public class PutMovieDto
        {

            public string Title { get; set; }
            public string Genre { get; set; }
            public int Year { get; set; }
            public string AgeRating { get; set; }
            public string Poster { get; set; }
        }

    }

  

