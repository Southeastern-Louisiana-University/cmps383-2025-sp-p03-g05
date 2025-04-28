import { useLocalSearchParams } from "expo-router";
import {
  Text,
  View,
  Image,
  StyleSheet,
  ScrollView,
  ActivityIndicator,
  Pressable,
  FlatList,
} from "react-native";
import { useEffect, useState } from "react";
import { useRouter } from "expo-router";
import { useNavigation } from "@react-navigation/native"; 


export const screenOptions = {
  title: 'Movie Details',
};

export default function MovieDetail() {
  const { id } = useLocalSearchParams();
  const navigation = useNavigation();
  const [movie, setMovie] = useState<any>(null);
  const [loading, setLoading] = useState(true);
  const [showtimes, setShowtimes] = useState<any[]>([]);
  const [theaters, setTheaters] = useState<any[]>([]);
  const router = useRouter();


  useEffect(() => {
    const fetchMovie = async () => {
      try {
        const response = await fetch(
          `https://selu383-sp25-p03-g05.azurewebsites.net/api/movies/${id}`
        );
        const data = await response.json();
        setMovie(data);
    
        navigation.setOptions({ title: data.title }); // 🆕 Set title dynamically
      } catch (error) {
        console.error("Error fetching movie:", error);
      } finally {
        setLoading(false);
      }
    };
    


    const fetchShowtimes = async () => {
      try {
        const response = await fetch(
          `https://selu383-sp25-p03-g05.azurewebsites.net/api/showtimes`
        );
        const data = await response.json();
        setShowtimes(data);
      } catch (error) {
        console.error("Error fetching showtimes:", error);
      }
    };


    const fetchTheaters = async () => {
      try {
        const response = await fetch(
          `https://selu383-sp25-p03-g05.azurewebsites.net/api/theaters`
        );
        const data = await response.json();
        setTheaters(data);
      } catch (error) {
        console.error("Error fetching theaters:", error);
      }
    };


    if (id) {
      fetchMovie();
      fetchShowtimes();
      fetchTheaters();
    }
  }, [id]);


  if (loading)
    return (
      <ActivityIndicator size="large" color="#a800b7" style={{ marginTop: 20 }} />
    );
  if (!movie)
    return (
      <Text style={{ color: "white", textAlign: "center", marginTop: 20 }}>
        Movie not found
      </Text>
    );


  const groupedByTheater = theaters.map((theater: any) => {
    const theaterShowtimes = showtimes.filter(
      (s) => s.movieId === movie.id && s.theaterId === theater.id && s.available
    );
    const groupedByFormat: { [key: string]: any[] } = {};
    theaterShowtimes.forEach((s) => {
      if (!groupedByFormat[s.format]) groupedByFormat[s.format] = [];
      groupedByFormat[s.format].push(s);
    });
    return {
      theaterName: theater.name,
      formats: groupedByFormat,
    };
  });


  return (
    <ScrollView style={styles.container}>
      <View style={styles.posterWrapper}>
        <Image
          source={{ uri: movie.poster }}
          style={styles.poster}
          resizeMode="contain"
        />
      </View>
      <Text style={styles.title}>{movie.title}</Text>
      <Text style={styles.info}>
        {movie.year} • {movie.ageRating} • {movie.genre}
      </Text>
      <Text style={styles.description}>{movie.description}</Text>


      {groupedByTheater.map((theater, idx) => {
        const hasShowtimes = Object.keys(theater.formats).length > 0;
        if (!hasShowtimes) return null;
        return (
          <View key={idx} style={{ marginTop: 24 }}>
            <Text style={styles.theaterName}>{theater.theaterName}</Text>
            {Object.entries(theater.formats).map(([format, shows], i) => (
              <View key={i}>
                <Text style={styles.format}>{format}</Text>
                <View style={styles.timeContainer}>
                  {shows.map((s: any) => (
                    <Pressable
                    key={s.id}
                    style={styles.timeButton}
                    onPress={() => {
                      console.log("Selected showtime:", s);
                      console.log("Navigating to theater ID:", s.theaterId);
                      router.push(`/seat-selector/${s.theaterId}`);
                    }}
                  >
                      <Text style={styles.timeText}>
                        {new Date(s.startTime).toLocaleTimeString([], {
                          hour: "numeric",
                          minute: "2-digit",
                        })}
                      </Text>
                    </Pressable>
                  ))}
                </View>
              </View>
            ))}
          </View>
        );
      })}
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
  theaterName: {
    color: "white",
    fontWeight: "bold",
    fontSize: 16,
    marginBottom: 4,
  },
  format: {
    color: "#ccc",
    marginBottom: 8,
    fontSize: 13,
  },
  timeContainer: {
    flexDirection: "row",
    flexWrap: "wrap",
    gap: 10,
    marginBottom: 16,
  },
  timeButton: {
    backgroundColor: "#000",
    paddingVertical: 8,
    paddingHorizontal: 14,
    borderRadius: 30,
    borderWidth: 1.5,
    borderColor: "#fff",
    marginBottom: 8,
  },
  timeText: {
    color: "#fff",
    fontWeight: "600",
  },
});
