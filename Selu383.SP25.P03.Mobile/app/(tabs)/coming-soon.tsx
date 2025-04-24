import { View, FlatList, Text, StyleSheet, ImageBackground, Pressable } from 'react-native';
import React, { useEffect, useState } from 'react';
import { useRouter } from 'expo-router';
import { useThemeContext } from '../ThemeContext';

export default function ComingSoon() {
  const { isDark } = useThemeContext();
  const router = useRouter();
  const [movies, setMovies] = useState<any[]>([]);

  useEffect(() => {
    const fetchMovies = async () => {
      try {
        const response = await fetch('https://selu383-sp25-p03-g05.azurewebsites.net/api/comingsoon');
        const data = await response.json();
        setMovies(data);
      } catch (error) {
        console.error('Error fetching coming soon movies:', error);
      }
    };

    fetchMovies();
  }, []);

  return (
    <View style={[styles.container, { backgroundColor: isDark ? '#000' : '#fff' }]}>
      <Text style={[styles.title, { color: isDark ? '#fff' : '#000' }]}>Coming Soon</Text>
      <FlatList
        data={movies}
        renderItem={({ item }) => (
          <Pressable onPress={() => router.push(`/movie/${item.id}`)} style={styles.cardWrapper}>
            <ImageBackground
              source={{ uri: item.poster }}
              style={styles.poster}
              resizeMode="cover"
            >
              <View style={styles.titleOverlay}>
                <Text style={styles.movieTitle} numberOfLines={1}>
                  {item.title}
                </Text>
              </View>
            </ImageBackground>
          </Pressable>
        )}
        keyExtractor={(item) => item.id.toString()}
        numColumns={2}
        columnWrapperStyle={{ justifyContent: 'space-between' }}
        contentContainerStyle={{ paddingHorizontal: 0, paddingBottom: 16 }}
        showsVerticalScrollIndicator={false}
      />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    paddingTop: 16,
  },
  title: {
    fontSize: 24,
    fontWeight: 'bold',
    marginBottom: 12,
    paddingHorizontal: 16,
  },
  cardWrapper: {
    width: '50%',
  },
  poster: {
    width: '100%',
    aspectRatio: 2 / 3,
    justifyContent: 'flex-end',
    borderRadius: 0,
  },
  titleOverlay: {
    backgroundColor: '#000',
    paddingVertical: 6,
    paddingHorizontal: 8,
  },
  movieTitle: {
    color: '#fff',
    fontSize: 13,
    fontWeight: 'bold',
    textAlign: 'center',
  },
});
