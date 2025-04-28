import React, { useState } from "react";
import {
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  DialogContentText,
  DialogTitle,
  TextField,
  Box,
  Snackbar,
  Alert as MuiAlert
} from "@mui/material";
import { useNavigate } from "react-router-dom";
//import { useRouter } from "next/router"; // Assuming Next.js (adjust if not)
//import AsyncStorage from "@react-native-async-storage/async-storage"; // Install if needed
//import { DeviceEventEmitter, Alert } from "react-native"; // Install if needed

interface LoginDialogProps {
  open: boolean;
  handleCloseDialog: () => void;
}

const LoginPopup: React.FC<LoginDialogProps> = ({ open, handleCloseDialog }) => {
  const navigate = useNavigate();
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState<string | null>(null);
  const [showError, setShowError] = useState(false);

  const handleLogin = async (event: React.FormEvent) => {
    event.preventDefault();
    setError(null);
    try {
      const response = await fetch(
        "https://selu383-sp25-p03-g05.azurewebsites.net/api/authentication/login",
        {
          method: "POST",
          headers: { "Content-Type": "application/json" },
          body: JSON.stringify({ userName: username, password }),
          credentials: "include", // Important for cookies/session
        }
      );

      if (!response.ok) {
        const errorData = await response.json();
        setError(errorData.message || "Invalid username or password");
        setShowError(true);
        return;
      }

      const user = await response.json();
      const role = user.roles?.[0] || "User";

      localStorage.setItem("user", JSON.stringify(user));
      localStorage.setItem("userRole", role);



      if (role === "Admin") {
        navigate("/admin-dashboard");
      } else {
        // If not admin, just close the login dialog
        handleCloseDialog();
      }
    } catch (error) {
      console.error("Login error:", error);
      setError("Something went wrong. Check backend connection.");
      setShowError(true);
    }
  };

  const handleCloseError = () => {
    setShowError(false);
  };

  return (
    <>
    <Dialog open={open} onClose={handleCloseDialog}>
      <DialogTitle>Login</DialogTitle>
      <form onSubmit={handleLogin}>
        <DialogContent>
          <DialogContentText>
            Please enter your Username and Password to log in.
          </DialogContentText>
          <Box sx={{ mt: 2 }}>
            <TextField
              autoFocus
              margin="dense"
              id="username"
              label="Username"
              type="text"
              fullWidth
              variant="outlined"
              value={username}
              onChange={(e) => setUsername(e.target.value)}
              required
            />
            <TextField
              margin="dense"
              id="password"
              label="Password"
              type="password"
              fullWidth
              variant="outlined"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              required
            />
          </Box>
        </DialogContent>
        <DialogActions>
          <Button onClick={handleCloseDialog}>Cancel</Button>
          <Button type="submit" variant="contained" color="primary">
            Login
          </Button>
        </DialogActions>
      </form>
    </Dialog>
    <Snackbar open={showError} autoHideDuration={6000} onClose={handleCloseError}>
      <MuiAlert elevation={6} variant="filled" severity="error" onClose={handleCloseError}>
        {error}
      </MuiAlert>
    </Snackbar>
    </>
  );
};

export default LoginPopup;

// // Example usage
// const App = () => {
//   const handleLogin = (email: string, password: string) => {
//     console.log('Login attempt:', { email, password });
//     // Here you would typically make an API call to authenticate the user
//   };

//   return (
//       <LoginPopup onSubmit={handleLogin} />
//   );
// };

// export default App;
