import { View, FlatList, Text, StyleSheet, Image } from 'react-native';
import { useThemeContext } from '../ThemeContext'; 
import React, { useState, useEffect } from 'react';


export default function HomePage() {
  const { isDark } = useThemeContext();
  const [movies, setMovies] = useState<any[]>([]); 

  useEffect(() => {
    
    const fetchMovies = async () => {
      try {
        const response = await fetch('https://selu383-sp25-p03-g05.azurewebsites.net/api/movies');
        const data = await response.json();
        setMovies(data);
      } catch (error) {
        console.error('Error fetching movies:', error);
      }
    };

    fetchMovies();
  }, []);

  return (
    <View style={[styles.container, { backgroundColor: isDark ? '#000' : '#fff' }]}>
      <Text style={[styles.title, { color: isDark ? '#fff' : '#000' }]}>Now Showing</Text>
      <FlatList
        data={movies}
        renderItem={({ item }) => (
          <View style={styles.card}>
            <Image source={{ uri: item.poster }} style={styles.poster} />
            <Text style={[styles.movieTitle, { color: isDark ? '#fff' : '#000' }]}>{item.title}</Text>
          </View>
        )}
        keyExtractor={(item) => item.id.toString()}
        numColumns={2}
        showsVerticalScrollIndicator={false}
      />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    paddingHorizontal: 8,
    paddingTop: 16,
  },
  title: {
    fontSize: 24,
    fontWeight: 'bold',
    marginBottom: 16,
  },
  card: {
    flex: 1,
    margin: 8,
    alignItems: 'center',
    backgroundColor: '#222',
    borderRadius: 8,
    padding: 8,
  },
  poster: {
    width: 150,
    height: 225,
    borderRadius: 8,
  },
  movieTitle: {
    marginTop: 8,
    fontSize: 16,
    textAlign: 'center',
  },
});
