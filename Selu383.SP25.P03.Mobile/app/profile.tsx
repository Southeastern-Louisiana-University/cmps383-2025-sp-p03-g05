import { useEffect, useState } from 'react';
import {
  View,
  Text,
  StyleSheet,
  ScrollView,
  TouchableOpacity,
  Switch,
} from 'react-native';
import AsyncStorage from '@react-native-async-storage/async-storage';
import { useRouter } from 'expo-router';

export default function ProfileScreen() {
  const router = useRouter();
  const [userName, setUserName] = useState('');
  const [roles, setRoles] = useState<string[]>([]);
  const [darkMode, setDarkMode] = useState(false);
  const [notificationsEnabled, setNotificationsEnabled] = useState(true);

  useEffect(() => {
    const loadUser = async () => {
      const stored = await AsyncStorage.getItem('user');
      if (stored) {
        const user = JSON.parse(stored);
        setUserName(user.userName);
        setRoles(user.roles || []);
      }
    };
    loadUser();
  }, []);

  const handleLogout = async () => {
    await AsyncStorage.removeItem('user');

    // Navigate to login AND trigger layout re-check
    router.replace('/(tabs)/login');
    setTimeout(() => {
      router.push('/(tabs)/login');
    }, 100);
  };

  const Section = ({ title }: { title: string }) => (
    <Text style={styles.sectionTitle}>{title}</Text>
  );

  const Item = ({ label, onPress }: { label: string; onPress?: () => void }) => (
    <TouchableOpacity onPress={onPress} style={styles.item}>
      <Text style={styles.itemText}>{label}</Text>
    </TouchableOpacity>
  );

  return (
    <ScrollView style={styles.container}>
      <Text style={styles.header}>
        Hello, <Text style={styles.username}>{userName}</Text>
      </Text>

      <Section title="Account" />
      <Item label="Edit Profile" />
      <Item label="Change Password" />

      <Section title="Preferences" />
      <View style={styles.item}>
        <Text style={styles.itemText}>Dark Mode</Text>
        <Switch value={darkMode} onValueChange={() => setDarkMode(!darkMode)} />
      </View>
      <View style={styles.item}>
        <Text style={styles.itemText}>Notifications</Text>
        <Switch
          value={notificationsEnabled}
          onValueChange={() => setNotificationsEnabled(!notificationsEnabled)}
        />
      </View>
      <Item label="Payment Method" />
      <Item label="Purchase History" />

      <Section title="About" />
      <Item label="Help & Support" />
      <Item label="Terms & Conditions" />
      <Item label="Privacy Policy" />

      <TouchableOpacity onPress={handleLogout} style={styles.logoutButton}>
        <Text style={styles.logoutText}>Logout</Text>
      </TouchableOpacity>
    </ScrollView>
  );
}

const PURPLE = '#a800b7';

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#000',
    padding: 16,
  },
  header: {
    fontSize: 24,
    color: '#fff',
    marginBottom: 20,
    fontWeight: 'bold',
  },
  username: {
    color: PURPLE,
  },
  sectionTitle: {
    fontSize: 18,
    color: PURPLE,
    fontWeight: '600',
    marginTop: 24,
    marginBottom: 12,
  },
  item: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    backgroundColor: '#1a1a1a',
    padding: 14,
    borderRadius: 10,
    marginBottom: 10,
  },
  itemText: {
    color: '#fff',
    fontSize: 15,
  },
  logoutButton: {
    backgroundColor: '#222',
    padding: 16,
    borderRadius: 10,
    marginTop: 32,
    alignItems: 'center',
  },
  logoutText: {
    color: '#fff',
    fontWeight: '600',
    fontSize: 16,
  },
});
