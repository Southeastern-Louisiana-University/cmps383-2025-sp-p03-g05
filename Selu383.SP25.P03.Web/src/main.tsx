import { StrictMode } from "react";
import { createRoot } from "react-dom/client";
import "./index.css";
import App from "./App.tsx";
import { SelectedTheaterProvider } from "./Location/LocationContext.tsx";
//import

createRoot(document.getElementById("root")!).render(
  <StrictMode>
    <SelectedTheaterProvider>
      <App />
    </SelectedTheaterProvider>
  </StrictMode>
);
