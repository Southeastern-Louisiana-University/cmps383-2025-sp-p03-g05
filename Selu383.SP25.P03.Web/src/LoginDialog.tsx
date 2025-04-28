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
import { useRouter } from 'next/router'; // Assuming Next.js (adjust if not)
import AsyncStorage from '@react-native-async-storage/async-storage'; // Install if needed
import { DeviceEventEmitter, Alert } from 'react-native'; // Install if needed

interface LoginFormProps {
  open: boolean;
  handleCloseDialog: () => void;
}

const LoginPopup: React.FC<LoginFormProps> = ({ open, handleCloseDialog }) => {
  const router = useRouter();
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');

  const handleLogin = async (event: React.FormEvent) => {
    event.preventDefault();
    try {
      const response = await fetch('https://selu383-sp25-p03-g05.azurewebsites.net/api/authentication/login', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ userName: username, password }),
        credentials: 'include', // Important for cookies/session
      });

      if (!response.ok) {
        const error = await response.json();
        Alert.alert('Login failed', error.message || 'Invalid username or password');
        return;
      }

      const user = await response.json();
      const role = user.roles?.[0] || 'User';

      await AsyncStorage.setItem('user', JSON.stringify(user));
      await AsyncStorage.setItem('userRole', role);

      DeviceEventEmitter.emit('authChanged');

      if (role === 'Admin') {
        router.replace('/admin-dashboard');
      } else {
        // If not admin, just close the login dialog
        handleCloseDialog();
      }
    } catch (error) {
      console.error('Login error:', error);
      Alert.alert('Error', 'Something went wrong. Check backend connection.');
    }
  };

  return (
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