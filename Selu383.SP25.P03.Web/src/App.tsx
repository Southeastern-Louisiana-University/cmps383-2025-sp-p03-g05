import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import LoginPage from "./LoginPage";
import RegisterPage from "./RegisterPage";
import "./App.css"; 
import SeatSelector from "./SeatSelector";
import "./SeatSelector.css"
import Home from "./Home"
import LocationPopup from "./LocationPopup";
import TheaterList from "./TheatersList";
import TheaterDetails from "./TheaterPage";
import MoviesList from "./MovieSelections";
import MovieDetails from "./MoviePage";

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/loginT" element={<LoginPage onClose={() => console.log("Login closed")} />} />
        <Route path="/register" element={<RegisterPage />} />
        <Route path="/seats" element={<SeatSelector />} /> 
        <Route path="/" element={<Home />}/>
        <Route path="/location" element={<LocationPopup/>} />
        <Route path="/theaters" element={<TheaterList/>}/>
        <Route path= "/theaters/:id" element={<TheaterDetails/>}/>
        <Route path="/movies" element={MoviesList()}/>
        <Route path="/movies/:id" element={<MovieDetails/>}/>
      </Routes>
    </Router>
  );
}

export default App;
