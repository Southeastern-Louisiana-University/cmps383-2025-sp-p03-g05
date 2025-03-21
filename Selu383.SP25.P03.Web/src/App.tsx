import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import LoginPage from "./LoginPage";
import RegisterPage from "./RegisterPage";
import "./App.css"; // ✅ Keep app.css for global styles

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<LoginPage onClose={() => console.log("Login closed")} />} />
        <Route path="/register" element={<RegisterPage />} />
      </Routes>
    </Router>
  );
}

export default App;
