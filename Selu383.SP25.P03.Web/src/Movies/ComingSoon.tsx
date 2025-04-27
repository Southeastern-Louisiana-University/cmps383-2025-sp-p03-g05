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
import { ComingSoon } from "../types.tsx";

function ComingSoonMovies() {
  const [futureMovies, setFutureMovies] = useState<ComingSoon[]>([]);

  useEffect(() => {
    fetch("/api/comingsoon")
      .then((response) => response.json())
      .then((data) => setFutureMovies(data))
      .catch((error) => console.error("Error fetching data:", error));
  }, []);

  return (
    <>
      {NavBar()}
      <Grid2
        container
        spacing={4}
        justifyContent="center"
        sx={{ width: "100%", margin: 0 }}
      >
        {futureMovies.map((movie) => (
          <Grid2 size={3}>
            <Link href={`/comingsoon/${movie.id}`} underline="none">
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
                  <Typography variant="body2">{movie.releaseYear}</Typography>
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
export default ComingSoonMovies;
