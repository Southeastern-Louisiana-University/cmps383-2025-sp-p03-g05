import { useState, useEffect } from "react";
import { useParams } from "react-router-dom";

type Showtime = {
    id: number;
    time: string;
    showDate: string;
    format: string;
    available: boolean;

};

type Theater = {
  id: number;
  name: string;
  address: string;
  seatCount: number;
  managerId: number;
  showtimes: Array<Showtime>;
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
    console.log("Theater data: ", theater);
    return (
        <>
        <h1>{theater.name}</h1>
        <h3>Showtimes</h3>
        
        <ul>
            {theater?.showtimes?.map((showtime) =>(
                <><li key={showtime.id}>{showtime.showDate}</li><li key={showtime.id}>{showtime.time}</li></>
            ))}
        </ul>
        </>
    )
  }
}
export default TheaterDetails;
