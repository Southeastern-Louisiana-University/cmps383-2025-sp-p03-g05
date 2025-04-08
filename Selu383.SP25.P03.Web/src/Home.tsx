import { Box, Button, Divider, Link, Typography } from "@mui/material";
import "./Home.css";
import MovieCarousel from "./MovieCarousel";
import NavBar from "./NavBar";
//import AccountCircleIcon from "@mui/icons-material/AccountCircle";
//import { Margin } from "@mui/icons-material";
//logo: /LDCDark.png


function Home() {
  return (
    <>
    {NavBar()}
      <div className="background">
        <div className="middleBanner">
          {/* <hr style={{ width: "100%", border: "2px solid black", margin: "20px 0" }} /> */}
          {/* <Typography
            variant="h3"
            sx={{ fontWeight: "bold" }}
            style={{ color: "white", margin: "50px" }}
          >
            Now Showing
          </Typography> */}
          {MovieCarousel()}
        </div>
        <div className="bottomBanner">
            <button className="showTimeButton">
                ShowTimes
            </button>

        </div>
            <Box sx={{ backgroundColor: "#1a1a1a", color: "#fff", padding: "40px 20px", textAlign: "center" }}>
  {/* Section Title */}
  <Typography variant="h4" sx={{ fontWeight: "bold", color: "#a800b7", marginBottom: "20px" }}>
    🎬 Exclusive Movie Offers 🎟️
  </Typography>

  {/* Promo Cards */}
  <Box sx={{ display: "flex", justifyContent: "center", flexWrap: "wrap", gap: "20px" }}>
    {/* First Offer */}
    <Box sx={{ backgroundColor: "#a800b7", padding: "20px", borderRadius: "10px", width: "250px", textAlign: "center" }}>
      <Typography variant="h6" sx={{ fontWeight: "bold", color: "#fff" }}>
        **BOGO Tickets!**  
      </Typography>
      <Typography variant="body2" sx={{ color: "#fff", marginBottom: "10px" }}>
        Buy one ticket, get one free for select movies! 🎟️
      </Typography>
      <button style={{ backgroundColor: "#fff", color: "#a800b7", padding: "10px", borderRadius: "5px", fontWeight: "bold", cursor: "pointer" }}>
        Grab the Deal
      </button>
    </Box>

    {/* Second Offer */}
    <Box sx={{ backgroundColor: "#a800b7", padding: "20px", borderRadius: "10px", width: "250px", textAlign: "center" }}>
      <Typography variant="h6" sx={{ fontWeight: "bold", color: "#fff" }}>
        **Student Discount 🎓**
      </Typography>
      <Typography variant="body2" sx={{ color: "#fff", marginBottom: "10px" }}>
        Show your student ID for **20% off** movie tickets!
      </Typography>
      <button style={{ backgroundColor: "#fff", color: "#a800b7", padding: "10px", borderRadius: "5px", fontWeight: "bold", cursor: "pointer" }}>
        Claim Discount
      </button>
    </Box>

    {/* Third Offer */}
    <Box sx={{ backgroundColor: "#a800b7", padding: "20px", borderRadius: "10px", width: "250px", textAlign: "center" }}>
      <Typography variant="h6" sx={{ fontWeight: "bold", color: "#fff" }}>
        **VIP Movie Night 🎥**
      </Typography>
      <Typography variant="body2" sx={{ color: "#fff", marginBottom: "10px" }}>
        Get premium seats + free popcorn 🍿 with a VIP ticket!
      </Typography>
      <button style={{ backgroundColor: "#fff", color: "#a800b7", padding: "10px", borderRadius: "5px", fontWeight: "bold", cursor: "pointer" }}>
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
