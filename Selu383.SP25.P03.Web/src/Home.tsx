import { Button, Divider, Link, Typography } from "@mui/material";
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
          <Typography
            variant="h3"
            sx={{ fontWeight: "bold" }}
            style={{ color: "white", margin: "50px" }}
          >
            Now Showing
          </Typography>
          <Divider sx={{ "--Divider-childPosition": `50%` }}></Divider>
          {MovieCarousel()}
        </div>
        <div className="bottomBanner"></div>
      </div>
    </>
  );
}

export default Home;
