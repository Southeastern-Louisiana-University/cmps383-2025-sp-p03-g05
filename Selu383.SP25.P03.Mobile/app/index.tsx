import React, { useState } from 'react';
import { View, Text, Pressable, StyleSheet, ScrollView, Image, Modal } from 'react-native';

const App = () => {
  const [showShowtimes, setShowShowtimes] = useState(false);

  const toggleShowtimes = () => {
    setShowShowtimes(!showShowtimes);
  };

  return (
    <ScrollView style={styles.container} contentContainerStyle={styles.contentContainer}>
      {/* Header Section */}
      <View style={styles.header}>
        <Text style={styles.logo}>LION'S DEN CINEMAS</Text>
      </View>

      {/* Main Content */}
      <View style={styles.mainContent}>
        {/* Now Showing Section */}
        <View style={styles.movieList}>
          <Text style={styles.sectionTitle}>Now Showing</Text>
          <ScrollView horizontal showsHorizontalScrollIndicator={false} contentContainerStyle={styles.movieCards}>
            {/* Spider-Man: No Way Home */}
            <View style={styles.movieCard}>
              <Image 
                source={{ uri: 'https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTf1LyFcoyBkyhy3FhxCzXXc49PhzDdO-GeSHJCj3nyCS9k95hG' }} 
                style={styles.movieImage} 
              />
              <Text style={styles.movieCardTitle}>Spider-Man: No Way Home</Text>
              <Text style={styles.movieCardDescription}>Action, Adventure, Sci-Fi</Text>
            </View>
            {/* Barbie */}
            <View style={styles.movieCard}>
              <Image 
                source={{ uri: 'https://image.tmdb.org/t/p/original/iuFNMS8U5cb6xfzi51Dbkovj7vM.jpg' }} 
                style={styles.movieImage} 
              />
              <Text style={styles.movieCardTitle}>Barbie</Text>
              <Text style={styles.movieCardDescription}>Comedy, Fantasy</Text>
            </View>
            {/* Snow White */}
            <View style={styles.movieCard}>
              <Image 
                source={{ uri: 'https://image.tmdb.org/t/p/original/oLxWocqheC8XbXbxqJ3x422j9PW.jpg' }} 
                style={styles.movieImage} 
              />
              <Text style={styles.movieCardTitle}>Snow White</Text>
              <Text style={styles.movieCardDescription}>Fantasy, Family</Text>
            </View>
          </ScrollView>
        </View>

        {/* Coming Soon Section */}
        <View style={styles.movieList}>
          <Text style={styles.sectionTitle}>Coming Soon</Text>
          <ScrollView horizontal showsHorizontalScrollIndicator={false} contentContainerStyle={styles.movieCards}>
            {/* The Flash */}
            <View style={styles.movieCard}>
              <Image 
                source={{ uri: 'https://image.tmdb.org/t/p/original/rktDFPbfHfUbArZ6OOOKsXcv0Bm.jpg' }} 
                style={styles.movieImage} 
              />
              <Text style={styles.movieCardTitle}>The Flash</Text>
              <Text style={styles.movieCardDescription}>Action, Adventure, Fantasy</Text>
            </View>
            {/* Oppenheimer */}
            <View style={styles.movieCard}>
              <Image 
                source={{ uri: 'https://image.tmdb.org/t/p/original/8Gxv8gSFCU0XGDykEGv7zR1n2ua.jpg' }} 
                style={styles.movieImage} 
              />
              <Text style={styles.movieCardTitle}>Oppenheimer</Text>
              <Text style={styles.movieCardDescription}>Drama, History</Text>
            </View>
          </ScrollView>
        </View>

        {/* Available Showtime Button */}
        <View style={styles.showtimesContainer}>
          <Pressable style={styles.showtimesButton} onPress={toggleShowtimes}>
            <Text style={styles.showtimesButtonText}>Available Showtimes</Text>
          </Pressable>
        </View>

        {/* Showtimes Modal */}
        {showShowtimes && (
          <View style={styles.showtimesModal}>
            <Text style={styles.showtimesModalTitle}>Showtimes for All Movies</Text>
            <Text style={styles.showtimesModalContent}>10:00 AM | 1:00 PM | 4:00 PM | 7:00 PM</Text>
          </View>
        )}

        {/* Food and Drinks Section */}
        <View style={styles.foodDrinksSection}>
          <Text style={styles.sectionTitle}>Food & Drinks</Text>
          <View style={styles.foodItem}>
            <Text style={styles.foodName}>Popcorn</Text>
            <Text style={styles.foodPrice}>$5.00</Text>
          </View>
          <View style={styles.foodItem}>
            <Text style={styles.foodName}>Soda</Text>
            <Text style={styles.foodPrice}>$3.00</Text>
          </View>
          <View style={styles.foodItem}>
            <Text style={styles.foodName}>Nachos</Text>
            <Text style={styles.foodPrice}>$4.50</Text>
          </View>
          <View style={styles.foodItem}>
            <Text style={styles.foodName}>Hot Dog</Text>
            <Text style={styles.foodPrice}>$3.50</Text>
          </View>
        </View>
      </View>

      {/* Footer */}
      <View style={styles.footer}>
        <Text style={styles.footerLink}>Home</Text>
        <Text style={styles.footerLink}>Offers</Text>
        <Text style={styles.footerLink}>My Membership</Text>
        <Text style={styles.footerLink}>Login</Text>
      </View>
    </ScrollView>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#f4f4f4',
  },
  contentContainer: {
    paddingBottom: 20,
  },
  header: {
    backgroundColor: '#a800b7',
    padding: 20,
    alignItems: 'center',
  },
  logo: {
    color: 'white',
    fontSize: 24,
  },
  mainContent: {
    padding: 20,
  },
  movieList: {
    marginBottom: 40,
  },
  sectionTitle: {
    fontSize: 24,
    color: '#333',
    marginBottom: 10,
  },
  movieCards: {
    flexDirection: 'row',
    flexWrap: 'wrap',
    justifyContent: 'space-between',
  },
  movieCard: {
    backgroundColor: 'white',
    padding: 10,
    borderRadius: 10,
    width: '48%',  // Ensuring same size for all cards
    marginBottom: 20,
    alignItems: 'center',
    shadowColor: '#000',
    shadowOpacity: 0.1,
    shadowRadius: 5,
    elevation: 2,
  },
  movieImage: {
    width: '100%',
    height: 200,
    borderRadius: 10,
    resizeMode: 'cover',
  },
  movieCardTitle: {
    fontSize: 16,
    color: '#333',
    marginTop: 10,
  },
  movieCardDescription: {
    fontSize: 14,
    color: '#777',
  },
  showtimesContainer: {
    marginTop: 20,
    alignItems: 'center',
  },
  showtimesButton: {
    backgroundColor: '#a800b7',
    padding: 15,
    borderRadius: 10,
    width: 200,
    alignItems: 'center',
  },
  showtimesButtonText: {
    color: 'white',
    fontSize: 18,
  },
  showtimesModal: {
    marginTop: 20,
    backgroundColor: '#fff',
    padding: 20,
    borderRadius: 10,
    alignItems: 'center',
  },
  showtimesModalTitle: {
    fontSize: 20,
    color: '#333',
    marginBottom: 10,
  },
  showtimesModalContent: {
    fontSize: 16,
    color: '#777',
  },
  foodDrinksSection: {
    marginTop: 30,
  },
  foodItem: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    paddingVertical: 10,
    borderBottomWidth: 1,
    borderColor: '#ccc',
  },
  foodName: {
    fontSize: 18,
    color: '#333',
  },
  foodPrice: {
    fontSize: 18,
    color: '#a800b7',
  },
  footer: {
    backgroundColor: '#333',
    padding: 10,
    textAlign: 'center',
  },
  footerLink: {
    color: 'white',
    marginTop: 10,
  },
});

export default App;
