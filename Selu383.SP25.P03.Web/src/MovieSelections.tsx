import {
  Card,
  CardContent,
  CardMedia,
  Grid2,
  Link,
  Typography,
} from "@mui/material";
import { useEffect, useState } from "react";
import NavBar from "./NavBar";
import { Movie } from "./types.tsx";

function MoviesList() {
  const [movies, setMovies] = useState<Movie[]>([]);

  useEffect(() => {
    fetch("/api/movies")
      .then((response) => response.json())
      .then((data) => setMovies(data))
      .catch((error) => console.error("Error fetching data:", error));
  }, []);

  return (
    <>
      {NavBar()}
        {/*<Typography variant="h3" sx={{ color: "#a800b7" }}>
          Current Selections
        </Typography>*/}
        <Grid2
          container
          spacing={1}
          justifyContent="center"
          sx={{ width: "100%", margin: 0 }}
        >
          {movies.map((movie) => (
            <Grid2 size={3}>
              <Link href={`/movies/${movie.id}`}>
                <Card
                  key={movie.id}
                  sx={{
                    border: 2,
                    borderColor: "#a800b7",
                    borderRadius: "7px",
                    height: 600,
                    display: "flex",
                    flexDirection: "column",
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
export default MoviesList;
