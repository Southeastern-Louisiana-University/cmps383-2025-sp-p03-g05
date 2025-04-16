import { useLocalSearchParams } from "expo-router";
import { Text, View, Image, StyleSheet, ScrollView, ActivityIndicator } from "react-native";
import { useEffect, useState } from "react";
import { useNavigation } from "@react-navigation/native";

export default function MovieDetail() {
  const { id } = useLocalSearchParams();
  const navigation = useNavigation();
  const [movie, setMovie] = useState<any>(null);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchMovie = async () => {
      try {
        const response = await fetch(`https://selu383-sp25-p03-g05.azurewebsites.net/api/movies/${id}`);
        const data = await response.json();
        setMovie(data);
        navigation.setOptions({ title: data.title });
      } catch (error) {
        console.error('Error fetching movie:', error);
      } finally {
        setLoading(false);
      }
    };

    if (id) {
      fetchMovie();
    }
  }, [id]);

  if (loading) return <ActivityIndicator size="large" color="#a800b7" style={{ marginTop: 20 }} />;
  if (!movie) return <Text style={{ color: "white", textAlign: 'center', marginTop: 20 }}>Movie not found</Text>;

  return (
    <ScrollView style={styles.container}>
      <View style={styles.posterWrapper}>
        <Image
          source={{ uri: movie.poster }}
          style={styles.poster}
          resizeMode="contain" // ✅ Ensures full poster is shown
        />
      </View>
      <Text style={styles.title}>{movie.title}</Text>
      <Text style={styles.info}>
        {movie.year} • {movie.ageRating} • {movie.genre}
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
  posterWrapper: {
    width: "100%",
    height: 300,
    borderRadius: 12,
    overflow: "hidden",
    backgroundColor: "#000", 
    marginBottom: 16,
  },
  poster: {
    width: "100%",
    height: "100%",
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
