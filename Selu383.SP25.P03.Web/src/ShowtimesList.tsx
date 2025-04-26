//When the user selects a movie and selects the "Get Tickets" button,
//It should pull up a list of showtimes based on locations
//This one shouldn't be too hard.
//We still need to figure out how to set the location throughout all parts of the website

import { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import { Theater, Showtime, Movie } from "./types.tsx";
import NavBar from "./NavBar.tsx";
import { useSelectedTheater } from "./Location/LocationContext.tsx";

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

  return (
    <>
      {NavBar()}
      {currentTheater ? (
        <div>
          <h2>
            Showtimes for {movie.title} at {currentTheater.name}{" "}
          </h2>
          <ul>
            {filteredShowtimes.map((showtime) => (
              <li key={showtime.id}>
                {new Date(showtime.startTime).toLocaleTimeString([], {
                  year: "numeric",
                  month: "2-digit",
                  day: "2-digit",
                  hour: "2-digit",
                  minute: "2-digit",
                })}
              </li>
            ))}
          </ul>
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
