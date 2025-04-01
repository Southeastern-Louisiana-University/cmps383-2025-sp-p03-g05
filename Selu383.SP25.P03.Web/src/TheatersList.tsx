import { useState, useEffect } from "react";
import Box from "@mui/material/Box";
import { Link } from "@mui/material";

type Theater = {
  id: number;
  name: string;
  address: string;
  seatCount: number;
  managerId: number;
};

const TheaterList = () => {
  const [theaters, setTheaters] = useState<Theater[]>([]);

  useEffect(() => {
    fetch("/api/theaters")
      .then((response) => response.json())
      .then((data) => setTheaters(data))
      .catch((error) => console.error("Error fetching data:", error));
  }, []);

  return (
    //remember to run the backend in Visual Studio to test this section
    <div>
      <h2>Select a Theater</h2>
      <ul>
        {theaters.map((theater) => (
          <Link href={`/theaters/${theater.id}`}>
            <Box
              key={theater.id}
              sx={{ border: 1, borderColor: "#a800b7", borderRadius: "7px" }}
            >
              <li>{theater.name}</li>
              <li>{theater.address}</li>
              <li>{theater.seatCount}</li>
              <br></br>
            </Box>
          </Link>
        ))}
      </ul>
    </div>
  );
};
export default TheaterList;
