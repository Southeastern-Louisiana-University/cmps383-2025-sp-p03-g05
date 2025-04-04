import { useEffect, useState } from "react";
import { Box, IconButton, Typography } from "@mui/material";
import { ArrowBackIos, ArrowForwardIos } from "@mui/icons-material";
import Movie from "./types"

const movies = [
  { title: "Monster House", image: "https://th.bing.com/th/id/OIP.1umjRUVLTbPQCPVU_q1HPgHaK-?rs=1&pid=ImgDetMain" },
  { title: "Jaws", image: "https://th.bing.com/th/id/OIP.8QS0RrtS6QJ5lDIU4Iy1GgHaLI?rs=1&pid=ImgDetMain" },
  { title: "Interstellar", image: "https://image.tmdb.org/t/p/w500/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg" },
  { title: "Avatar", image: "https://image.tmdb.org/t/p/w500/kyeqWdyUXW608qlYkRqosgbbJyK.jpg" },
  { title: "Titanic", image: "https://image.tmdb.org/t/p/w500/9xjZS2rlVxm8SFx8kPC3aIGCOYQ.jpg" }
];

const MovieCarousel = () => {
  const [currentIndex, setCurrentIndex] = useState(0);
  const Movie = 
  const [movies, setMovies] = useState<Movie[]>([]);

  const nextSlide = () => {
    setCurrentIndex((prevIndex) => (prevIndex + 1) % movies.length);
  };

  const prevSlide = () => {
    setCurrentIndex((prevIndex) => (prevIndex - 1 + movies.length) % movies.length);
  };

  useEffect(() => {
    fetch("/api/movies")
      .then((response) => response.json())
      .then((data) => setMovies(data))
      .catch((error) => console.error("Error fetching data:", error));
  }, []);

  return (
    <Box sx={{ position: "relative", width: "300px", height: "450px", margin: "auto", overflow: "hidden" }}>
      
      {/* Movie Poster Display */}
      {movies.map((movie, index) => (
        <div>

        <Box
          key={index}
          sx={{
            display: index === currentIndex ? "block" : "none",
            width: "100%",
            height: "100%",
            backgroundImage: `url(${movie.image})`,
            backgroundSize: "cover",
            backgroundPosition: "center",
            position: "absolute",
            transition: "opacity 0.5s ease-in-out",
            "&:hover": {
              "& .titleOverlay": { opacity: 1 }
            }
          }}
        >
          {/* Movie Title Overlay */}
          <Typography
            className="titleOverlay"
            variant="h6"
            sx={{
              position: "absolute",
              bottom: 0,
              left: 0,
              width: "100%",
              backgroundColor: "rgba(0, 0, 0, 0.7)",
              color: "#fff",
              textAlign: "center",
              padding: "10px",
              opacity: 0,
              transition: "opacity 0.3s ease-in-out"
            }}
          >
            {movie.title}
          </Typography>
        </Box>
        </div>
      ))}

      {/* Left Button */}
      <IconButton 
        onClick={prevSlide}
        sx={{
          position: "absolute", top: "50%", left: 10, transform: "translateY(-50%)",
          backgroundColor: "rgba(0,0,0,0.5)", color: "#fff", "&:hover": { backgroundColor: "rgba(0,0,0,0.7)" }
        }}
      >
        <ArrowBackIos />
      </IconButton>

      {/* Right Button */}
      <IconButton 
        onClick={nextSlide}
        sx={{
          position: "absolute", top: "50%", right: 10, transform: "translateY(-50%)",
          backgroundColor: "rgba(0,0,0,0.5)", color: "#fff", "&:hover": { backgroundColor: "rgba(0,0,0,0.7)" }
        }}
      >
        <ArrowForwardIos />
      </IconButton>
    </Box>
  );
};

export default MovieCarousel;

