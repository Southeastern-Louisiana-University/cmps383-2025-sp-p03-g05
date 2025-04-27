//When the user selects a movie and selects the "Get Tickets" button,
//It should pull up a list of showtimes based on locations
//This one shouldn't be too hard.
//We still need to figure out how to set the location throughout all parts of the website

import { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import { Theater, Showtime, Movie } from "./types.tsx";
import NavBar from "./NavBar.tsx";
import { useSelectedTheater } from "./Location/LocationContext.tsx";
import { Button } from "@mui/material";

function MovieShowtimes() {
  const { id } = useParams();
  const [showtimes, setShowtimes] = useState<Showtime[]>([]);
  const [movie, setMovie] = useState<Movie>();
  const [currentTheater, setCurrentTheater] = useState<Theater>();

  const theaterContext = useSelectedTheater();

  useEffect(() => {
    fetch(`/api/movies/${id}`)
      .then((response) => response.json())
      .then((data) => setMovie(data))
      .catch((error) => console.error("Error fetching movie:", error));
  }, []);

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

  if (!showtimes || !movie) {
    return <p>Loading...</p>;
  }

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
    //for each showtime that has been filtered by the movie id and theater id
    //create a new date object with its

    if (!groupedShowtimes[date]) {
      groupedShowtimes[date] = [];
    }

    groupedShowtimes[date].push(showtime);
  });

  return (
    <>
      {NavBar()}
      {currentTheater ? (
        <div>
          <h2>
            Showtimes for {movie.title} at {currentTheater.name}{" "}
          </h2>

          {Object.entries(groupedShowtimes).map(([date, showtimes]) => (
            <div key={date}>
              <h3>{date}</h3>
              <ul>
                {showtimes.map((showtime) => (
                  <Button
                    variant="contained"
                    key={showtime.id}
                    href="/seats"
                    sx={{ backgroundColor: "#a800b7",
                      '&:hover': {
                        backgroundColor: "#8a009b",
                        color: "white"
                      }
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
        </div>
      ) : (
        <p>
          No showtimes available at {theaterContext.theater?.theaterName} for{" "}
          {movie.title}
        </p>
      )}
    </>
  );
}
export default MovieShowtimes;
