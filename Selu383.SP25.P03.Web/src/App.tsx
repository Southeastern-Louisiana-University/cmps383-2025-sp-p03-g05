import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import LoginPage from "./LoginPage";
import RegisterPage from "./RegisterPage";
import "./App.css"; 
import SeatSelector from "./SeatSelector";
import "./SeatSelector.css"
import HomePage from "./Home"

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<LoginPage onClose={() => console.log("Login closed")} />} />
        <Route path="/register" element={<RegisterPage />} />
        <Route path="/seats" element={<SeatSelector />} /> 
        <Route path="/home" element={HomePage()}/>
      </Routes>
    </Router>
  );
}

export default App;
