import { useState, useEffect } from "react";
import { Button, Stack, Typography } from "@mui/material";
import { useSelectedTheater } from "./LocationContext";
import { Theater } from "../types";
import NavBar from "../NavBar";

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
      {NavBar()}
      <div>
        <h2>Select a Theater</h2>
        <ul>
          <Stack spacing={2}>
            {theaters.map((theater) => (
              <Button
                variant="contained"
                sx={{ textTransform: "none", backgroundColor: "#a800b7" }}
                onClick={() => {
                  theaterContext.setSelectedTheater({
                    theaterId: theater.id,
                    theaterName: theater.name,
                  });
                  //sets the selected theater
                }}
                href="/"
                size="large"
                //returns the user back to the homepage
              >
                <Typography variant="body2">{theater.name}</Typography>
              </Button>
            ))}
          </Stack>
        </ul>
      </div>
    </>
  );
};
export default TheaterList;
