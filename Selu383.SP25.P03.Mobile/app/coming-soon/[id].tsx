import { View, Text, StyleSheet, Image, ScrollView } from 'react-native';
import { useLocalSearchParams } from 'expo-router';
import React, { useEffect, useState } from 'react';
import { useThemeContext } from '../ThemeContext';

export default function ComingSoonDetail() {
  const { id } = useLocalSearchParams();
  const { isDark } = useThemeContext();
  const [movie, setMovie] = useState<any>(null);

  useEffect(() => {
    const fetchMovie = async () => {
      try {
        const response = await fetch(`https://selu383-sp25-p03-g05.azurewebsites.net/api/comingsoon/${id}`);
        const data = await response.json();
        setMovie(data);
      } catch (error) {
        console.error('Error fetching movie details:', error);
      }
    };

    fetchMovie();
  }, [id]);

  if (!movie) {
    return (
      <View style={[styles.container, { backgroundColor: isDark ? '#000' : '#fff' }]}>
        <Text style={{ color: isDark ? '#fff' : '#000' }}>Loading...</Text>
      </View>
    );
  }

  return (
    <ScrollView style={[styles.container, { backgroundColor: isDark ? '#000' : '#fff' }]}>
      <Image source={{ uri: movie.poster }} style={styles.poster} />
      <View style={styles.detailsContainer}>
        <Text style={[styles.title, { color: isDark ? '#fff' : '#000' }]}>{movie.title}</Text>
        <Text style={[styles.info, { color: isDark ? '#ccc' : '#333' }]}>Rating: {movie.ageRating}</Text>
        <Text style={[styles.info, { color: isDark ? '#ccc' : '#333' }]}>Genre: {movie.genre}</Text>
        <Text style={[styles.description, { color: isDark ? '#ccc' : '#333' }]}>{movie.description}</Text>
      </View>
    </ScrollView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
  },
  poster: {
    width: '100%',
    height: 400,
    resizeMode: 'cover',
  },
  detailsContainer: {
    padding: 16,
  },
  title: {
    fontSize: 28,
    fontWeight: 'bold',
    marginBottom: 8,
  },
  info: {
    fontSize: 16,
    marginBottom: 4,
  },
  description: {
    marginTop: 12,
    fontSize: 16,
    lineHeight: 22,
  },
});
