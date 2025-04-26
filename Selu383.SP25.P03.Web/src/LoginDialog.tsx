
import React, { useState } from 'react';
import {
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  DialogContentText,
  DialogTitle,
  TextField,
  Box
} from '@mui/material';

interface LoginFormProps {
  onSubmit: (email: string, password: string) => void;
  open: boolean;
  handleCloseDialog: () => void;
}

const LoginPopup: React.FC<LoginFormProps> = ({ open, handleCloseDialog, onSubmit }) => {
  // State for controlling the dialog
  //const [open, setOpen] = useState(false);
  
  // State for form inputs
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  // // Handle opening the dialog
  // const handleClickOpen = () => {
  //   setOpen(true);
  // };

  // // Handle closing the dialog
  // const handleClose = () => {
  //   setOpen(false);
  // };

  // Handle form submission
  const handleSubmit = (event: React.FormEvent) => {
    event.preventDefault();
    onSubmit(email, password);
    handleCloseDialog();
    // Reset form
    setEmail('');
    setPassword('');
  };

  return (
    <div>
      {/* Button that triggers the login popup
      <Button variant="contained" color="primary" onClick={handleClickOpen}>
        Login
      </Button> */}
      
      {/* Dialog popup */}
      <Dialog open={open} onClose={handleCloseDialog}>
        <DialogTitle>Login</DialogTitle>
        <form onSubmit={handleSubmit}>
          <DialogContent>
            <DialogContentText>
              Please enter your email and password to log in.
            </DialogContentText>
            <Box sx={{ mt: 2 }}>
              <TextField
                autoFocus
                margin="dense"
                id="email"
                label="Email Address"
                type="email"
                fullWidth
                variant="outlined"
                value={email}
                onChange={(e) => setEmail(e.target.value)}
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
    </div>
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