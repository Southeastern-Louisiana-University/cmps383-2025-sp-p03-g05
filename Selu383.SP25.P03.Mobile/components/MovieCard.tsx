// MovieCard

import { useRouter } from "expo-router";
import { Text, View, Image, TouchableOpacity } from "react-native";
import React from "react";

export default function MovieCard({ movie }) {
  const router = useRouter();

  return (
    <TouchableOpacity
      onPress={() => router.push(`/movie/${movie.id}`)}
      style={{
        flex: 1,
        margin: 8,
        backgroundColor: "#111",
        borderRadius: 12,
        overflow: "hidden",
        shadowColor: "#000",
        shadowOffset: { width: 0, height: 4 },
        shadowOpacity: 0.3,
        shadowRadius: 6,
        elevation: 5,
      }}
    >
      <Image
        source={{ uri: movie.image }}
        style={{ width: "100%", height: 180 }}
        resizeMode="cover"
      />
      <View style={{ padding: 10 }}>
        <Text style={{ color: "#fff", fontWeight: "bold", fontSize: 16 }}>{movie.title}</Text>
      </View>
    </TouchableOpacity>
  );
}
