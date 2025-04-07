import { useEffect, useState } from 'react';
import {
  View,
  Text,
  StyleSheet,
  ScrollView,
  TouchableOpacity,
  Switch,
  DeviceEventEmitter,
} from 'react-native';
import AsyncStorage from '@react-native-async-storage/async-storage';
import { useRouter } from 'expo-router';
import { useThemeContext } from './ThemeContext'; 

export default function ProfileScreen() {
  const router = useRouter();
  const { isDark, toggleTheme } = useThemeContext(); 
  const [userName, setUserName] = useState('');
  const [roles, setRoles] = useState<string[]>([]);
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
    DeviceEventEmitter.emit('authChanged');
    router.replace('/(tabs)/login');
  };

  const Section = ({ title }: { title: string }) => (
    <Text style={[styles.sectionTitle, { color: '#a800b7' }]}>{title}</Text>
  );

  const Item = ({ label, onPress }: { label: string; onPress?: () => void }) => (
    <TouchableOpacity
      onPress={onPress}
      style={[styles.item, { backgroundColor: isDark ? '#1a1a1a' : '#f0f0f0' }]}
    >
      <Text style={[styles.itemText, { color: isDark ? '#fff' : '#000' }]}>{label}</Text>
    </TouchableOpacity>
  );

  return (
    <ScrollView style={[styles.container, { backgroundColor: isDark ? '#000' : '#fff' }]}>
      <Text style={[styles.header, { color: isDark ? '#fff' : '#000' }]}>Hello, <Text style={styles.username}>{userName}</Text></Text>

      <Section title="Account" />
      <Item label="Edit Profile" />
      <Item label="Change Password" />

      <Section title="Preferences" />
      <View style={[styles.item, { backgroundColor: isDark ? '#1a1a1a' : '#f0f0f0' }]}>
        <Text style={[styles.itemText, { color: isDark ? '#fff' : '#000' }]}>Dark Mode</Text>
        <Switch value={isDark} onValueChange={toggleTheme} />
      </View>
      <View style={[styles.item, { backgroundColor: isDark ? '#1a1a1a' : '#f0f0f0' }]}>
        <Text style={[styles.itemText, { color: isDark ? '#fff' : '#000' }]}>Notifications</Text>
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

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 16,
  },
  header: {
    fontSize: 24,
    marginBottom: 20,
    fontWeight: 'bold',
  },
  username: {
    color: '#a800b7',
  },
  sectionTitle: {
    fontSize: 18,
    fontWeight: '600',
    marginTop: 24,
    marginBottom: 12,
  },
  item: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    padding: 14,
    borderRadius: 10,
    marginBottom: 10,
  },
  itemText: {
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
