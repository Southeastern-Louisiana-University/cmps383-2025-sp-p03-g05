import React from "react";
import LocationPopup from "./LocationPopup";
import "./App.css"; 

const App: React.FC = () => {
  return (
    <div>
      <header style={styles.header}>
        <h1 style={styles.logo}>🎥 Lions Den Cinemas</h1>
      </header>
      <main>
        <LocationPopup />
      </main>
    </div>
  );
};

const styles = {
  header: {
    backgroundColor: "#a800b7",
    padding: "1rem 0",
    textAlign: "center" as const,
    boxShadow: "0 4px 10px rgba(0, 0, 0, 0.3)",
  },
  logo: {
    color: "#fff",
    fontFamily: "'Poppins', sans-serif",
    margin: 0,
    fontSize: "1.75rem",
  },
};

export default App;
