import { View, Text, FlatList, StyleSheet, TouchableOpacity, Image } from 'react-native';
import { comingSoonMovies } from '@/constants/comingSoonMovies';
import { useRouter } from 'expo-router';
import { useThemeContext } from '../ThemeContext';

export default function ComingSoon() {
  const router = useRouter();
  const { isDark } = useThemeContext();

  if (!Array.isArray(comingSoonMovies)) {
    return (
      <Text style={{ color: isDark ? '#fff' : '#000', padding: 20 }}>
        No upcoming movies
      </Text>
    );
  }

  return (
    <View style={[styles.container, { backgroundColor: isDark ? '#000' : '#f5f5f5' }]}>
      <Text style={[styles.heading, { color: isDark ? '#fff' : '#000' }]}>Coming Soon</Text>
      <FlatList
        data={comingSoonMovies}
        keyExtractor={(item) => item.id}
        numColumns={2}
        renderItem={({ item }) => (
          <TouchableOpacity
            onPress={() => router.push(`/movie/${item.id}`)}
            style={[styles.card, { backgroundColor: isDark ? '#111' : '#fff' }]}
          >
            <Image source={{ uri: item.image }} style={styles.image} />
            <Text style={[styles.title, { color: isDark ? '#fff' : '#000' }]}>
              {item.title}
            </Text>
          </TouchableOpacity>
        )}
      />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 16,
  },
  heading: {
    fontSize: 22,
    fontWeight: 'bold',
    marginBottom: 16,
  },
  card: {
    flex: 1,
    borderRadius: 12,
    margin: 8,
    overflow: 'hidden',
    elevation: 4,
    shadowColor: '#000',
    shadowOffset: { width: 0, height: 3 },
    shadowOpacity: 0.2,
    shadowRadius: 4,
  },
  image: {
    height: 200,
    width: '100%',
  },
  title: {
    fontWeight: 'bold',
    fontSize: 14,
    padding: 8,
  },
});
