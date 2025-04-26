import {
  Card,
  CardContent,
  CardMedia,
  Grid2,
  Link,
  Typography,
} from "@mui/material";
import { useEffect, useState } from "react";
import NavBar from "../NavBar.tsx";
import { Movie, Theater } from "../types.tsx";
import { useSelectedTheater } from "../Location/LocationContext.tsx";

function NowShowing() {
  const [movies, setMovies] = useState<Movie[]>([]);
  const [currentTheater, setCurrentTheater] = useState<Theater>();

  const theaterContext  = useSelectedTheater();

  useEffect(() => {
    fetch("/api/movies")
      .then((response) => response.json())
      .then((data) => setMovies(data))
      .catch((error) => console.error("Error fetching data:", error));
  }, []);

  useEffect(() => {
    fetch(`/api/theaters/${theaterContext?.theater?.theaterId}`)
      .then((response) => response.json())
      .then((data) => setCurrentTheater(data))
      .catch((error) => console.error("Error fetching data:", error));
  }, [theaterContext]);

  const filteredMovies = currentTheater?.showtimes
    ? movies.filter((movie) =>
        currentTheater.showtimes.some(
          (showtime) => showtime.movieId === movie.id
        )
      )
    : [];

  return (
    <>
      {NavBar()}
      <Grid2
        container
        spacing={4}
        justifyContent="center"
        sx={{ width: "100%", margin: 0 }}
      >
        {filteredMovies.map((movie) => (
          <Grid2 size={3}>
            <Link href={`/movies/${movie.id}`} underline="none">
              <Card
                key={movie.id}
                sx={{
                  border: 2,
                  borderColor: "#a800b7",
                  borderRadius: "7px",
                  height: 600,
                  display: "flex",
                  flexDirection: "column",
                  ":hover": {
                    boxShadow: 20,
                  },
                }}
              >
                <CardMedia sx={{ height: 500 }} image={movie.poster} />
                <CardContent sx={{ flex: 1, textAlign: "center" }}>
                  <Typography variant="h6" sx={{ fontWeight: "bold" }}>
                    {movie.title}
                  </Typography>
                  <Typography variant="body2">{movie.genre}</Typography>
                  <Typography variant="body2">{movie.year}</Typography>
                  <Typography variant="body2">{movie.ageRating}</Typography>
                </CardContent>
              </Card>
            </Link>
          </Grid2>
        ))}
      </Grid2>
    </>
  );
}
export default NowShowing;
