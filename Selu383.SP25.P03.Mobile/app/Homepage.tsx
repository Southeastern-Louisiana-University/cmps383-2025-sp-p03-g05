import React from 'react';
import { View, Text, Pressable, StyleSheet, ScrollView, Image } from 'react-native';

interface Theater {
  name: string;
  location: string;
  imageUrl: string;
}

const HomeScreen = () => {
  const theaters: Theater[] = [
    { name: 'Cinemark', location: 'Louisiana', imageUrl: 'https://placekitten.com/200/200' },
    { name: 'AMC Theaters', location: 'New Orleans', imageUrl: 'https://placekitten.com/200/200' },
    { name: 'Regal Cinema', location: 'Baton Rouge', imageUrl: 'https://placekitten.com/200/200' },
    { name: 'Movie Tavern', location: 'Kenner', imageUrl: 'https://placekitten.com/200/200' },
  ];

  return (
    <ScrollView style={styles.container}>
      <Text style={styles.title}>Explore Theaters</Text>
      
      <View style={styles.theatersContainer}>
        {theaters.map((theater, index) => (
          <View key={index} style={styles.theaterCard}>
            <Image source={{ uri: theater.imageUrl }} style={styles.image} />
            <Text style={styles.theaterName}>{theater.name}</Text>
            <Text style={styles.theaterLocation}>{theater.location}</Text>
          </View>
        ))}
      </View>

      <Pressable style={styles.button} onPress={() => console.log('Explore more theaters')}>
        <Text style={styles.buttonText}>Explore More Theaters</Text>
      </Pressable>
    </ScrollView>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#f7f7f7',
    paddingHorizontal: 20,
    paddingVertical: 10,
  },
  title: {
    fontSize: 32,
    fontWeight: '700',
    color: '#a800b7',
    textAlign: 'center',
    marginBottom: 20,
  },
  theatersContainer: {
    marginBottom: 20,
  },
  theaterCard: {
    backgroundColor: '#fff',
    borderRadius: 12,
    padding: 10,
    marginBottom: 15,
    shadowColor: '#000',
    shadowOpacity: 0.1,
    shadowRadius: 5,
    elevation: 2,
    alignItems: 'center',
  },
  image: {
    width: 150,
    height: 150,
    borderRadius: 10,
    marginBottom: 10,
  },
  theaterName: {
    fontSize: 20,
    fontWeight: '600',
    color: '#333',
  },
  theaterLocation: {
    fontSize: 16,
    color: '#777',
  },
  button: {
    backgroundColor: '#a800b7',
    padding: 14,
    borderRadius: 10,
    alignItems: 'center',
    marginTop: 20,
    elevation: 5,
  },
  buttonText: {
    color: '#fff',
    fontSize: 18,
    fontWeight: '600',
  },
});

export default HomeScreen;
