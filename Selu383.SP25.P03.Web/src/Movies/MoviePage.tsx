import { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import { Movie } from "../types.tsx";
import NavBar from "../NavBar.tsx";
import { Box, Button, Stack, Typography } from "@mui/material";

function MovieDetails() {
  const { id } = useParams();
  const [movie, setMovie] = useState<Movie>();

  useEffect(() => {
    fetch(`/api/movies/${id}`)
      .then((response) => response.json())
      .then((data) => setMovie(data))
      .catch((error) => console.error("Error fetching movie: ", error));
  }, [id]);

  if (movie) {
    return (
      <>
        {NavBar()}
        <Stack direction="row" spacing={2}>
          <Box
            component="img"
            sx={{ height: 600, width: 400 }}
            src={movie.poster}
          ></Box>
          <Box>
            <Typography variant="h2">{movie.title}</Typography>
            <Typography variant="body1">{movie.description}</Typography>
            <Button
              variant="contained"
              href={`/movies/${movie.id}/showtimes`}
              sx={{
                backgroundColor: "#a800b7",
                "&:hover": {
                  backgroundColor: "#8a009b",
                  color: "white",
                },
              }}
            >
              See Showtimes
            </Button>
          </Box>
        </Stack>
      </>
    );
  }
}
export default MovieDetails;
