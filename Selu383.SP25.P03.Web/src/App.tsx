import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import LoginPage from "./LoginPage";
import RegisterPage from "./RegisterPage";
import "./App.css"; 
import SeatSelector from "./SeatSelector";
import "./SeatSelector.css"
import HomePage from "./Home"
import LocationPopup from "./LocationPopup";
import TheaterList from "./TheatersList";
import TheaterDetails from "./TheaterPage";
import MoviesList from "./MovieSelections";

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
        {/* <Route path="/movies" element={MoviesList()}/> */}
      </Routes>
    </Router>
  );
}

export default App;
