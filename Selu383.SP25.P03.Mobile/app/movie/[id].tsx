import { useLocalSearchParams } from "expo-router";
import { movies } from "@/constants/mockMovies";
import { Text, View, Image, StyleSheet, ScrollView } from "react-native";
import { useEffect } from "react";
import { useNavigation } from "@react-navigation/native";

export default function MovieDetail() {
  const { id } = useLocalSearchParams();
  const movie = movies.find((m) => m.id === id);

  const navigation = useNavigation();

  useEffect(() => {
    if (movie) {
      navigation.setOptions({ title: movie.title });
    }
  }, [movie]);

  if (!movie) return <Text style={{ color: "white" }}>Movie not found</Text>;

  return (
    <ScrollView style={styles.container}>
      <Image source={{ uri: movie.image }} style={styles.poster} />
      <Text style={styles.title}>{movie.title}</Text>
      <Text style={styles.info}>
        {movie.duration} • {movie.ageRating} • ⭐ {movie.rating}
      </Text>
      <Text style={styles.description}>{movie.description}</Text>
    </ScrollView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#000",
    padding: 16,
  },
  poster: {
    width: "100%",
    height: 300,
    borderRadius: 12,
    marginBottom: 16,
  },
  title: {
    color: "#a800b7",
    fontSize: 24,
    fontWeight: "bold",
    marginBottom: 8,
  },
  info: {
    color: "#ccc",
    fontSize: 14,
    marginBottom: 16,
  },
  description: {
    color: "white",
    fontSize: 16,
    lineHeight: 24,
  },
});
