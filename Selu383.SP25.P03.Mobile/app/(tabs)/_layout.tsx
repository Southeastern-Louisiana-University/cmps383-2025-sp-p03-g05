import { Tabs } from 'expo-router';
import { Ionicons } from '@expo/vector-icons';
import { useEffect, useState } from 'react';
import AsyncStorage from '@react-native-async-storage/async-storage';
import { AppState, DeviceEventEmitter } from 'react-native';

export default function TabLayout() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const checkLogin = async () => {
    const user = await AsyncStorage.getItem('user');
    setIsLoggedIn(!!user);
  };

  useEffect(() => {
    checkLogin(); // Initial load

    const appStateSub = AppState.addEventListener('change', (state) => {
      if (state === 'active') {
        checkLogin();
      }
    });

    const logoutSub = DeviceEventEmitter.addListener('authChanged', checkLogin);

    return () => {
      appStateSub.remove();
      logoutSub.remove();
    };
  }, []);

  return (
    <Tabs
      screenOptions={{
        tabBarStyle: { backgroundColor: '#000', borderTopColor: '#111' },
        tabBarLabelStyle: { fontSize: 12 },
        tabBarActiveTintColor: '#a800b7',
        headerShown: false,
      }}
    >
      <Tabs.Screen
        name="index"
        options={{
          title: 'Home',
          tabBarIcon: ({ color, size }) => (
            <Ionicons name="home-outline" size={size} color={color} />
          ),
        }}
      />
      <Tabs.Screen
        name="coming-soon"
        options={{
          title: 'Coming Soon',
          tabBarIcon: ({ color, size }) => (
            <Ionicons name="time-outline" size={size} color={color} />
          ),
        }}
      />
      <Tabs.Screen
        name="food"
        options={{
          title: 'Food',
          tabBarIcon: ({ color, size }) => (
            <Ionicons name="fast-food-outline" size={size} color={color} />
          ),
        }}
      />
      {isLoggedIn ? (
        <Tabs.Screen
          name="profile"
          options={{
            title: 'Profile',
            tabBarIcon: ({ color, size }) => (
              <Ionicons name="person-outline" size={size} color={color} />
            ),
          }}
        />
      ) : (
        <Tabs.Screen
          name="login"
          options={{
            title: 'Login',
            tabBarIcon: ({ color, size }) => (
              <Ionicons name="log-in-outline" size={size} color={color} />
            ),
          }}
        />
      )}
    </Tabs>
  );
}
