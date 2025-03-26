import React from 'react';
import {
  View,
  Text,
  StyleSheet,
  FlatList,
  Image,
  TouchableOpacity,
  Dimensions,
} from 'react-native';

const { width } = Dimensions.get('window');
const CARD_WIDTH = width * 0.38; // tighter for mobile
const CARD_SPACING = 12;
const POSTER_HEIGHT = 160;

const movies = [
  {
    id: '1',
    title: 'Oppenheimer',
    poster: 'https://picsum.photos/id/1003/400/600',
  },
  {
    id: '2',
    title: 'Dune: Part Two',
    poster: 'https://picsum.photos/id/1018/400/600',
  },
  {
    id: '3',
    title: 'Inside Out 2',
    poster: 'https://picsum.photos/id/1025/400/600',
  },
];

export default function HomeScreen() {
  return (
    <View style={styles.container}>
      <Text style={styles.heading}>Now Showing</Text>
      <FlatList
        data={movies}
        keyExtractor={(item) => item.id}
        horizontal
        showsHorizontalScrollIndicator={false}
        contentContainerStyle={{ paddingHorizontal: CARD_SPACING }}
        renderItem={({ item }) => (
          <TouchableOpacity style={styles.card}>
            <Image
              source={{ uri: item.poster }}
              style={styles.poster}
              resizeMode="cover"
            />
            <Text style={styles.title}>{item.title}</Text>
          </TouchableOpacity>
        )}
      />
    </View>
  );
}

const PURPLE = '#a800b7';

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    paddingTop: 40,
  },
  heading: {
    fontSize: 22,
    fontWeight: 'bold',
    color: PURPLE,
    marginBottom: 12,
    marginLeft: 16,
  },
  card: {
    width: CARD_WIDTH,
    marginRight: CARD_SPACING,
    alignItems: 'center',
  },
  poster: {
    width: '100%',
    height: POSTER_HEIGHT,
    borderRadius: 10,
    backgroundColor: '#eee',
  },
  title: {
    marginTop: 8,
    fontSize: 13,
    fontWeight: '600',
    color: '#333',
    textAlign: 'center',
  },
});
