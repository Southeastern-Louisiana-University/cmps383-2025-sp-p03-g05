import { useEffect, useState } from 'react';
import { 
  View, 
  Text, 
  StyleSheet, 
  ScrollView, 
  TouchableOpacity, 
  Switch, 
  DeviceEventEmitter, 
  Image 
} from 'react-native';
import AsyncStorage from '@react-native-async-storage/async-storage';
import { useRouter } from 'expo-router';
import { useThemeContext } from './ThemeContext';
import { Ionicons } from '@expo/vector-icons';

export default function ProfileScreen() {
  const router = useRouter();
  const { isDark, toggleTheme } = useThemeContext();
  const [userName, setUserName] = useState('');
  const [email, setEmail] = useState('');
  const [roles, setRoles] = useState<string[]>([]);
  const [notificationsEnabled, setNotificationsEnabled] = useState(true);

  useEffect(() => {
    const loadUser = async () => {
      const stored = await AsyncStorage.getItem('user');
      if (stored) {
        const user = JSON.parse(stored);
        setUserName(user.userName);
        setEmail(user.email);
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

  const handleEditProfile = () => {
    console.log('Navigating to Edit Profile');
    router.push('/edit-profile');
  };

  const handleChangePassword = () => {
    router.push('/change-password');
  };

  const Section = ({ title }: { title: string }) => (
    <Text style={[styles.sectionTitle, { color: '#a800b7' }]}>{title}</Text>
  );

  const Item = ({ label, onPress, icon }: { label: string; onPress?: () => void; icon?: JSX.Element }) => (
    <TouchableOpacity onPress={onPress} style={[styles.item, { backgroundColor: isDark ? '#1a1a1a' : '#f0f0f0' }]}>
      <View style={styles.itemContent}>
        {icon && <View style={styles.iconContainer}>{icon}</View>}
        <Text style={[styles.itemText, { color: isDark ? '#fff' : '#000' }]}>{label}</Text>
      </View>
    </TouchableOpacity>
  );

  return (
    <ScrollView style={[styles.container, { backgroundColor: isDark ? '#000' : '#fff' }]}>
      <View style={styles.profileHeader}>
        <Image 
          source={{ uri: 'https://www.w3schools.com/w3images/avatar2.png' }} 
          style={styles.profileImage} 
        />
        <Text style={[styles.header, { color: isDark ? '#fff' : '#000' }]}>Hello, <Text style={styles.username}>{userName}</Text></Text>
        <Text style={[styles.email, { color: isDark ? '#fff' : '#000' }]}>{email}</Text>
      </View>

      <Section title="Account" />
      <Item label="Edit Profile" onPress={handleEditProfile} icon={<Ionicons name="create-outline" size={20} color={isDark ? '#fff' : '#000'} />} />
      <Item label="Change Password" onPress={handleChangePassword} icon={<Ionicons name="key-outline" size={20} color={isDark ? '#fff' : '#000'} />} />

      <Section title="Preferences" />
      <View style={[styles.item, { backgroundColor: isDark ? '#1a1a1a' : '#f0f0f0' }]}>
        <Text style={[styles.itemText, { color: isDark ? '#fff' : '#000' }]}>Dark Mode</Text>
        <Switch value={isDark} onValueChange={toggleTheme} />
      </View>
      <View style={[styles.item, { backgroundColor: isDark ? '#1a1a1a' : '#f0f0f0' }]}>
        <Text style={[styles.itemText, { color: isDark ? '#fff' : '#000' }]}>Notifications</Text>
        <Switch value={notificationsEnabled} onValueChange={() => setNotificationsEnabled(!notificationsEnabled)} />
      </View>

      <Item label="Payment Method" icon={<Ionicons name="card-outline" size={20} color={isDark ? '#fff' : '#000'} />} />
      <Item label="Purchase History" icon={<Ionicons name="time-outline" size={20} color={isDark ? '#fff' : '#000'} />} />

      <Section title="About" />
      <Item label="Help & Support" icon={<Ionicons name="help-circle-outline" size={20} color={isDark ? '#fff' : '#000'} />} />
      <Item label="Terms & Conditions" icon={<Ionicons name="document-text-outline" size={20} color={isDark ? '#fff' : '#000'} />} />
      <Item label="Privacy Policy" icon={<Ionicons name="shield-checkmark-outline" size={20} color={isDark ? '#fff' : '#000'} />} />

      <Section title="Logout" />
      <Item label="Logout" onPress={handleLogout} icon={<Ionicons name="log-out-outline" size={20} color={isDark ? '#fff' : '#000'} />} />
    </ScrollView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 16,
  },
  profileHeader: {
    alignItems: 'center',
    marginBottom: 20,
  },
  profileImage: {
    width: 80,
    height: 80,
    borderRadius: 40,
    marginBottom: 10,
  },
  header: {
    fontSize: 24,
    fontWeight: 'bold',
  },
  username: {
    color: '#a800b7',
  },
  email: {
    fontSize: 14,
    color: '#aaa',
    marginTop: 5,
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
  itemContent: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  iconContainer: {
    marginRight: 10,
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

