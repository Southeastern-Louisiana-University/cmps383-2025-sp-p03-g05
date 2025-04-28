import { Box, Typography } from "@mui/material";
import "./Home.css";
import MovieCarousel from "../Movies/MovieCarousel";
import NavBar from "../NavBar";
import { useSelectedTheater } from "../Location/LocationContext";

//logo: /LDCDark.png

function Home() {
  const currentTheater = useSelectedTheater();
  //context to use the currently selected theater in the pages.
  console.log("Selected theater:", currentTheater.theater);

  return (
    <>
      <NavBar />
      <div className="background">
        <div className="middleBanner">
          <div></div>
          <MovieCarousel />
        </div>
        <div className="bottomBanner"></div>
        <Box
          sx={{
            backgroundColor: "#1a1a1a",
            color: "#fff",
            padding: "40px 20px",
            textAlign: "center",
          }}
        >
          {/* Section Title */}
          <Typography
            variant="h4"
            sx={{ fontWeight: "bold", color: "#a800b7", marginBottom: "20px" }}
          >
            Exclusive Movie Offers
          </Typography>

          {/* Promo Cards */}
          <Box
            sx={{
              display: "flex",
              justifyContent: "center",
              flexWrap: "wrap",
              gap: "20px",
            }}
          >
            {/* First Offer */}
            <Box
              sx={{
                backgroundColor: "#a800b7",
                padding: "20px",
                borderRadius: "10px",
                width: "250px",
                textAlign: "center",
              }}
            >
              <Typography
                variant="h6"
                sx={{ fontWeight: "bold", color: "#fff" }}
              >
                **BOGO Tickets!**
              </Typography>
              <Typography
                variant="body2"
                sx={{ color: "#fff", marginBottom: "10px" }}
              >
                Buy one ticket, get one free for select movies! 🎟️
              </Typography>
              <button
                style={{
                  backgroundColor: "#fff",
                  color: "#a800b7",
                  padding: "10px",
                  borderRadius: "5px",
                  fontWeight: "bold",
                  cursor: "pointer",
                }}
              >
                Grab the Deal
              </button>
            </Box>

            {/* Second Offer */}
            <Box
              sx={{
                backgroundColor: "#a800b7",
                padding: "20px",
                borderRadius: "10px",
                width: "250px",
                textAlign: "center",
              }}
            >
              <Typography
                variant="h6"
                sx={{ fontWeight: "bold", color: "#fff" }}
              >
                **Student Discount 🎓**
              </Typography>
              <Typography
                variant="body2"
                sx={{ color: "#fff", marginBottom: "10px" }}
              >
                Show your student ID for **20% off** movie tickets!
              </Typography>
              <button
                style={{
                  backgroundColor: "#fff",
                  color: "#a800b7",
                  padding: "10px",
                  borderRadius: "5px",
                  fontWeight: "bold",
                  cursor: "pointer",
                }}
              >
                Claim Discount
              </button>
            </Box>

            {/* Third Offer */}
            <Box
              sx={{
                backgroundColor: "#a800b7",
                padding: "20px",
                borderRadius: "10px",
                width: "250px",
                textAlign: "center",
              }}
            >
              <Typography
                variant="h6"
                sx={{ fontWeight: "bold", color: "#fff" }}
              >
                **VIP Movie Night 🎥**
              </Typography>
              <Typography
                variant="body2"
                sx={{ color: "#fff", marginBottom: "10px" }}
              >
                Get premium seats + free popcorn 🍿 with a VIP ticket!
              </Typography>
              <button
                style={{
                  backgroundColor: "#fff",
                  color: "#a800b7",
                  padding: "10px",
                  borderRadius: "5px",
                  fontWeight: "bold",
                  cursor: "pointer",
                }}
              >
                Upgrade Now
              </button>
            </Box>
          </Box>
        </Box>
      </div>
    </>
  );
}

export default Home;
