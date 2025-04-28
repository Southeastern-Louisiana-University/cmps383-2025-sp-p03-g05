//MovieCarousel.tsx
import { useEffect, useState } from "react";
import { Box, Typography } from "@mui/material";
import { Movie } from "../types";
import { Swiper, SwiperSlide } from "swiper/react";
import { Navigation, Autoplay } from "swiper/modules";
import "swiper/css";
import "swiper/css/navigation";
import "./MovieCarousel.css"; // still can use your CSS if needed

const MovieCarousel = () => {
  const [movies, setMovies] = useState<Movie[]>([]);

  useEffect(() => {
    fetch("/api/movies")
      .then((response) => response.json())
      .then((data) => setMovies(data))
      .catch((error) => console.error("Error fetching data:", error));
  }, []);

  return (
    <Box
      sx={{
        width: "100%",
        maxWidth: "1200px",
        margin: "auto",
        padding: "20px 0",
      }}
    >
      <Swiper
        modules={[Navigation, Autoplay]}
        navigation
        autoplay={{ delay: 5000 }}
        spaceBetween={20}
        slidesPerView={3}
        loop
        style={{ paddingBottom: "40px" }} // extra padding for navigation buttons
      >
        {movies.map((movie, index) => (
          <SwiperSlide key={index}>
            <Box
              sx={{
                position: "relative",
                width: "100%",
                height: "400px",
                backgroundImage: `url(${movie.poster})`,
                backgroundSize: "cover",
                backgroundPosition: "center",
                borderRadius: "12px",
                overflow: "hidden",
                cursor: "pointer",
                "&:hover .titleOverlay": {
                  opacity: 1,
                },
              }}
            >
              {/* Movie Title Overlay */}
              <Box
                className="titleOverlay"
                sx={{
                  position: "absolute",
                  bottom: 0,
                  width: "100%",
                  backgroundColor: "rgba(0, 0, 0, 0.7)",
                  color: "#fff",
                  textAlign: "center",
                  padding: "10px",
                  opacity: 0,
                  transition: "opacity 0.3s ease-in-out",
                }}
              >
              </Box>
            </Box>
          </SwiperSlide>
        ))}
      </Swiper>
    </Box>
  );
};

export default MovieCarousel;

