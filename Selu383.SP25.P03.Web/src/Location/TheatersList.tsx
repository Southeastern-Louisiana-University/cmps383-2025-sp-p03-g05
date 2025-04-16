import { useState, useEffect } from "react";
import { Button, Stack, Typography } from "@mui/material";
import { useSelectedTheater } from "./LocationContext";

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

  const selected = useSelectedTheater();

  return (
    <>
      {/*remember to run the backend in Visual Studio to test this section*/}
      {/* */}
      <div>
        <h2>Select a Theater</h2>
        <ul>
          {theaters.map((theater) => (
            <Stack spacing={2}>
              <Button
                variant="contained"
                type="button"
                sx={{ textTransform: "none" }}
                onClick= {() => {
                  console.log("foo")
                  selected.setSelectedTheater({
                    theaterId: theater.id,
                    theaterName: theater.name
                  })
                }}

              >
                <Typography variant="body2">{theater.name} {selected.theater?.theaterId === theater.id ? "SELECTED" : ""}</Typography>
              </Button>
            </Stack>
          ))}
        </ul>
      </div>
    </>
  );
};
export default TheaterList;
