import "./Home.css";
import MovieCarousel from "./Movies/MovieCarousel";
import NavBar from "./NavBar";
//import AccountCircleIcon from "@mui/icons-material/AccountCircle";
//import { Margin } from "@mui/icons-material";
//logo: /LDCDark.png


function Home() {


  return (
    <>
    {NavBar()}
      <div className="background">90
        <div className="middleBanner">
          <div></div>
          {MovieCarousel()}
        </div>
      </div>
    </>
  );
}

export default Home;
