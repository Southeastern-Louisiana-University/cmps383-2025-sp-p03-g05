import { View, Text, ScrollView } from "react-native";
import MovieCard from "@/components/MovieCard";
import { upcomingMovies } from "@/constants/mockMovies";

export default function ComingSoon() {
  return (
    <ScrollView style={{ backgroundColor: "#000", padding: 16 }}>
      <Text style={{ color: "#fff", fontSize: 24, marginBottom: 20 }}>Coming Soon</Text>
      {upcomingMovies.map((movie) => (
        <MovieCard key={movie.id} movie={movie} />
      ))}
    </ScrollView>
  );
}
