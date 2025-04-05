// app/(tabs)/index.tsx

import { View, FlatList, Text } from "react-native";
import { movies } from "@/constants/mockMovies";
import MovieCard from "@/components/MovieCard";

export default function HomePage() {
  return (
    <View style={{ backgroundColor: "#000", flex: 1, paddingHorizontal: 8, paddingTop: 16 }}>
      <Text style={{ color: "#fff", fontSize: 24, fontWeight: "bold", marginBottom: 16 }}>
        Now Showing
      </Text>
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
