import { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import { Movie, Showtime, Theater } from "../types.tsx";
import NavBar from "../NavBar.tsx";
import { Box, Button, Stack, Typography } from "@mui/material";
import { useSelectedTheater } from "../Location/LocationContext.tsx";

function MovieDetails() {
  const { id } = useParams();
  const [movie, setMovie] = useState<Movie>();
  const [currentTheater, setCurrentTheater] = useState<Theater>();
  const [showtimes, setShowtimes] = useState<Showtime[]>([]);

  const theaterContext = useSelectedTheater();

  useEffect(() => {
    fetch(`/api/movies/${id}`)
      .then((response) => response.json())
      .then((data) => setMovie(data))
      .catch((error) => console.error("Error fetching movie: ", error));
  }, [id]);

  useEffect(() => {
    fetch(`/api/theaters/${theaterContext?.theater?.theaterId}`)
      .then((response) => response.json())
      .then((data) => setCurrentTheater(data))
      .catch((error) => console.error("Error fetching theater:", error));
  }, [theaterContext]);

  useEffect(() => {
    fetch(`/api/showtimes/${id}`)
      .then((response) => response.json())
      .then((data) => setShowtimes(data))
      .catch((error) => console.error("Error fetching showtimes:", error));
  }, []);

  const filteredShowtimes = currentTheater
    ? showtimes.filter((showtime) => showtime.theaterId === currentTheater.id)
    : [];

  const groupedShowtimes: Record<string, typeof filteredShowtimes> = {};

  filteredShowtimes.forEach((showtime: Showtime) => {
    const date = new Date(showtime.startTime).toLocaleDateString([], {
      year: "numeric",
      month: "long",
      day: "2-digit",
    });

    if (!groupedShowtimes[date]) {
      groupedShowtimes[date] = [];
    }

    groupedShowtimes[date].push(showtime);
  });

  if (!movie || !showtimes) {
    return <p>Loading...</p>;
  }

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
          <br />
          <h2>Showtimes at {currentTheater?.name}:</h2>
          {Object.entries(groupedShowtimes)
            .sort((a, b) => new Date(a[0]).getTime() - new Date(b[0]).getTime())
            .map(([date, showtimes]) => (
              <div key={date}>
                <h3>{date}</h3>
                <ul>
                  {showtimes.map((showtime) => (
                    <Button
                      variant="contained"
                      key={showtime.id}
                      href={`/seats/${theaterContext.theater?.theaterId}`}
                      sx={{
                        backgroundColor: "#a800b7",
                        "&:hover": {
                          backgroundColor: "#8a009b",
                          color: "white",
                        },
                      }}
                    >
                      {new Date(showtime.startTime).toLocaleTimeString([], {
                        hour: "2-digit",
                        minute: "2-digit",
                        hour12: true,
                      })}
                    </Button>
                  ))}
                </ul>
              </div>
            ))}
        </Box>
      </Stack>
    </>
  );
}
export default MovieDetails;
