import { useEffect, useState } from 'react';
import {
  View,
  Text,
  StyleSheet,
  TextInput,
  TouchableOpacity,
  Alert,
  ActivityIndicator,
  DeviceEventEmitter,
} from 'react-native';
import AsyncStorage from '@react-native-async-storage/async-storage';
import { useRouter } from 'expo-router';
import ProfileScreen from '../profile';

const PURPLE = '#a800b7';

export default function LoginTab() {
  const router = useRouter();
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [loading, setLoading] = useState(true);
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  useEffect(() => {
    const checkLogin = async () => {
      const stored = await AsyncStorage.getItem('user');
      setIsLoggedIn(!!stored);
      setLoading(false);
    };

    checkLogin();
    const sub = DeviceEventEmitter.addListener('authChanged', checkLogin);
    return () => sub.remove();
  }, []);

  const handleLogin = async () => {
    try {
      const response = await fetch('http://10.0.2.2:5249/api/authentication/login', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ userName: username, password }),
        credentials: 'include',
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

      DeviceEventEmitter.emit('authChanged'); // 🔥 Key line for logout sync

      if (role === 'Admin') {
        router.replace('/admin-dashboard');
      } else {
        setIsLoggedIn(true);
      }
    } catch (error) {
      console.error('Login error:', error);
      Alert.alert('Error', 'Something went wrong. Check backend connection.');
    }
  };

  if (loading) {
    return (
      <View style={styles.center}>
        <ActivityIndicator size="large" color={PURPLE} />
      </View>
    );
  }

  if (isLoggedIn) {
    return <ProfileScreen />;
  }

  return (
    <View style={styles.container}>
      <Text style={styles.heading}>Welcome Back!</Text>

      <TextInput
        style={styles.input}
        placeholder="Username"
        placeholderTextColor="#999"
        onChangeText={setUsername}
        value={username}
      />

      <TextInput
        style={styles.input}
        placeholder="Password"
        placeholderTextColor="#999"
        secureTextEntry
        onChangeText={setPassword}
        value={password}
      />

      <TouchableOpacity onPress={handleLogin} style={styles.button}>
        <Text style={styles.buttonText}>Login</Text>
      </TouchableOpacity>

      <TouchableOpacity onPress={() => Alert.alert('Reset Password', 'Feature coming soon')}>
        <Text style={styles.link}>Forgot Password?</Text>
      </TouchableOpacity>

      <TouchableOpacity onPress={() => router.push('/register')}>
        <Text style={styles.link}>First time? Create an Account</Text>
      </TouchableOpacity>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    paddingHorizontal: 24,
    justifyContent: 'center',
  },
  heading: {
    fontSize: 24,
    color: PURPLE,
    fontWeight: 'bold',
    marginBottom: 24,
    textAlign: 'center',
  },
  input: {
    height: 48,
    borderColor: '#ccc',
    borderWidth: 1,
    borderRadius: 8,
    paddingHorizontal: 12,
    marginBottom: 16,
    fontSize: 16,
  },
  button: {
    backgroundColor: PURPLE,
    paddingVertical: 12,
    borderRadius: 8,
    marginBottom: 20,
  },
  buttonText: {
    color: '#fff',
    fontSize: 16,
    textAlign: 'center',
    fontWeight: '600',
  },
  link: {
    color: PURPLE,
    fontSize: 14,
    textAlign: 'center',
    marginTop: 8,
    textDecorationLine: 'underline',
  },
  center: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
  },
});
