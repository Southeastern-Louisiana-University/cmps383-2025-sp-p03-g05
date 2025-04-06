import { View, Text, FlatList, StyleSheet, TouchableOpacity, Image } from "react-native";
import { comingSoonMovies } from "@/constants/comingSoonMovies";
import { useRouter } from "expo-router";

export default function ComingSoon() {
  const router = useRouter();

  if (!Array.isArray(comingSoonMovies)) {
    return <Text style={{ color: "white", padding: 20 }}>No upcoming movies</Text>;
  }

  return (
    <View style={styles.container}>
      <Text style={styles.heading}>Coming Soon</Text>
      <FlatList
        data={comingSoonMovies}
        keyExtractor={(item) => item.id}
        numColumns={2}
        renderItem={({ item }) => (
          <TouchableOpacity
            onPress={() => router.push(`/movie/${item.id}`)}
            style={styles.card}
          >
            <Image source={{ uri: item.image }} style={styles.image} />
            <Text style={styles.title}>{item.title}</Text>
          </TouchableOpacity>
        )}
      />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#000",
    padding: 16,
  },
  heading: {
    fontSize: 22,
    fontWeight: "bold",
    color: "white",
    marginBottom: 16,
  },
  card: {
    flex: 1,
    backgroundColor: "#111",
    borderRadius: 12,
    margin: 8,
    overflow: "hidden",
  },
  image: {
    height: 200,
    width: "100%",
  },
  title: {
    color: "white",
    fontWeight: "bold",
    fontSize: 14,
    padding: 8,
  },
});
