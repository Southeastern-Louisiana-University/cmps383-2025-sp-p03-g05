import { useState, useEffect } from "react";
import { Button, Stack, Typography } from "@mui/material";
import { useSelectedTheater } from "./LocationContext";
import { Theater } from "../types";

const TheaterList = () => {
  const [theaters, setTheaters] = useState<Theater[]>([]);

  useEffect(() => {
    fetch("/api/theaters")
      .then((response) => response.json())
      .then((data) => setTheaters(data))
      .catch((error) => console.error("Error fetching data:", error));
  }, []);

  const theaterContext = useSelectedTheater();
  console.log("Selected theater: ", theaterContext);


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
                  theaterContext.setSelectedTheater({
                    theaterId: theater.id,
                    theaterName: theater.name
                  })
                  //sets the selected theater
                }}
                href="/"
                //returns the user back to the homepage
              >
                <Typography variant="body2">{theater.name} {theaterContext.theater?.theaterId === theater.id ? "SELECTED" : ""}</Typography>
                {/* Will change, this was testing the context*/}
              </Button>
            </Stack>
          ))}
        </ul>
      </div>
    </>
  );
};
export default TheaterList;
