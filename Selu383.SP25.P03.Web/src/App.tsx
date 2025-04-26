import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import LoginPage from "./Login/LoginPage";
import RegisterPage from "./RegisterPage";
import "./App.css";
import SeatSelector from "./SeatSelector";
import "./SeatSelector.css";
import HomePage from "./Home/Home";
import TheaterList from "./Location/TheatersList";
import TheaterDetails from "./Location/TheaterPage";
import NowShowing from "./Movies/NowShowing";
import MovieDetails from "./Movies/MoviePage";
import MovieShowtimes from "./ShowtimesList";
function App() {
  return (
    <Router>
      <Routes>
        <Route
          path="/login"
          element={<LoginPage onClose={() => console.log("Login closed")} />}
        />
        <Route path="/register" element={<RegisterPage />} />
        <Route path="/seats" element={<SeatSelector />} />
        <Route path="/" element={<HomePage />} />
        <Route path="/theaters" element={<TheaterList />} />
        <Route path="/theaters/:id" element={<TheaterDetails />} />
        <Route path="/movies" element={<NowShowing />} />
        <Route path="/movies/:id" element={<MovieDetails />} />
        <Route path="/movies/:id/showtimes" element={<MovieShowtimes />} />
      </Routes>
    </Router>
  );
}

export default App;
