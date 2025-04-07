// app/(tabs)/index.tsx

import { View, FlatList, Text, StyleSheet } from 'react-native';
import { movies } from '@/constants/mockMovies';
import MovieCard from '@/components/MovieCard';
import { useThemeContext } from '../ThemeContext';

export default function HomePage() {
  const { isDark } = useThemeContext();

  return (
    <View style={[styles.container, { backgroundColor: isDark ? '#000' : '#fff' }]}>
      <Text style={[styles.title, { color: isDark ? '#fff' : '#000' }]}>Now Showing</Text>
      <FlatList
        data={movies}
        renderItem={({ item }) => <MovieCard movie={item} />}
        keyExtractor={(item) => item.id}
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
});
