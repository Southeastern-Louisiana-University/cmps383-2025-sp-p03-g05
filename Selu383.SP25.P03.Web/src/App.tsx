import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import LoginPage from "./Login/LoginPage";
import RegisterPage from "./RegisterPage";
import "./App.css"; 
import SeatSelector from "./SeatSelector";
import "./SeatSelector.css"
import HomePage from "./Home/Home"
import LocationPopup from "./Location/LocationPopup";
import TheaterList from "./Location/TheatersList";
import TheaterDetails from "./Location/TheaterPage";
import MoviesList from "./MovieSelections";
import MovieDetails from "./Movies/MoviePage";

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/login" element={<LoginPage onClose={() => console.log("Login closed")} />} />
        <Route path="/register" element={<RegisterPage />} />
        <Route path="/seats" element={<SeatSelector />} /> 
        <Route path="/" element={<HomePage />}/>
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
