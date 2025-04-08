import { useState, useEffect } from "react";
import { useParams } from "react-router-dom";

type Theater = {
  id: number;
  name: string;
  address: string;
  seatCount: number;
  managerId: number;
  showtimes: Array<Showtime>;
};

type Showtime = {
  id: number;
  time: string;
  startTime: string;
  format: string;
  available: boolean;
};

function TheaterDetails() {
  const { id } = useParams();
  const [theater, setTheater] = useState<Theater>();

  useEffect(() => {
    fetch(`/api/theaters/${id}`)
      .then((response) => response.json())
      .then((data) => setTheater(data))
      .catch((error) => console.error("Error fetching theater:", error));
  }, [id]);

  if (theater) {
    console.log("Showtimes: ", theater?.showtimes);

    return (
      <>
        <h1>{theater.name}</h1>
        <h3>Showtimes</h3>

        <ul>
          {theater.showtimes.map((showtime) => {
            const date = new Date(showtime.startTime);
            const formatted = date.toLocaleString("en-US", {
              year: "numeric",
              month: "long",
              day: "numeric",
              hour: "numeric",
              minute: "2-digit",
              hour12: true,
            });
            return <li key={showtime.id}>{formatted}</li>;
          })}
        </ul>
      </>
    );
  }
}
export default TheaterDetails;
