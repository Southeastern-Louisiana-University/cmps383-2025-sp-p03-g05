import { View, Text, StyleSheet, TouchableOpacity, Alert } from 'react-native';
import { useRouter } from 'expo-router';
import AsyncStorage from '@react-native-async-storage/async-storage';

const PURPLE = '#a800b7';

export const unstable_settings = {
    initialRouteName: 'admin-dashboard',
  };
  
  export const screenOptions = {
    title: 'Admin Panel',
    headerStyle: {
      backgroundColor: '#000',
    },
    headerTintColor: '#a800b7',
    headerTitleAlign: 'center',
  };
  

export default function AdminDashboard() {
  const router = useRouter();

  const handleLogout = async () => {
    await AsyncStorage.removeItem('user');
    await AsyncStorage.removeItem('userRole');
    router.replace('/'); 
  };

  const handleComingSoon = (feature: string) => {
    Alert.alert('Coming Soon!', `${feature} management will be added later.`);
  };

  return (
    <View style={styles.container}>
      <Text style={styles.title}> Admin Dashboard</Text>

      <TouchableOpacity style={styles.card} onPress={() => handleComingSoon('Movie')}>
        <Text style={styles.cardText}>Manage Movies </Text>
      </TouchableOpacity>

      <TouchableOpacity style={styles.card} onPress={() => handleComingSoon('Food')}>
        <Text style={styles.cardText}>Manage Food </Text>
      </TouchableOpacity>

      <TouchableOpacity style={styles.card} onPress={() => handleComingSoon('User')}>
        <Text style={styles.cardText}>View Users </Text>
      </TouchableOpacity>

      <TouchableOpacity style={styles.card} onPress={() => handleComingSoon('Sales')}>
        <Text style={styles.cardText}>View Sales </Text>
      </TouchableOpacity>

      <TouchableOpacity style={[styles.card, styles.logout]} onPress={handleLogout}>
        <Text style={styles.cardText}>Logout </Text>
      </TouchableOpacity>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#121212',
    padding: 24,
    paddingTop: 64,
  },
  title: {
    fontSize: 28,
    fontWeight: 'bold',
    color: PURPLE,
    marginBottom: 32,
    textAlign: 'center',
  },
  card: {
    backgroundColor: '#1f1f1f',
    padding: 20,
    borderRadius: 16,
    marginBottom: 16,
    shadowColor: '#000',
    shadowOpacity: 0.2,
    shadowOffset: { width: 0, height: 2 },
    shadowRadius: 4,
  },
  cardText: {
    color: '#fff',
    fontSize: 18,
    textAlign: 'center',
  },
  logout: {
    backgroundColor: '#420b4f',
    marginTop: 32,
  },
});
