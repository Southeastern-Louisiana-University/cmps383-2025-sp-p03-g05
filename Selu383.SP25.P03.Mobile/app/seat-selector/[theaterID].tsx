import React, { useEffect, useState } from 'react';
import { View, Text, StyleSheet, ScrollView, Pressable, TouchableOpacity } from 'react-native';
import { useLocalSearchParams } from 'expo-router';

type Seat = {
  id: string; 
  isBooked: boolean;
};

export default function SeatSelector() {
  const { theaterID } = useLocalSearchParams();
  const [seatsLayout, setSeatsLayout] = useState<(Seat | null)[][]>([]);
  const [selectedSeats, setSelectedSeats] = useState<string[]>([]);

  useEffect(() => {
    if (theaterID) {
      generateSeatsForTheater(theaterID as string);
    }
  }, [theaterID]);

  const generateSeatsForTheater = (theaterId: string) => {
    let layout: (Seat | null)[][] = [];
  
    if (theaterId === '1') {
      for (let row = 0; row < 10; row++) {
        let currentRow: (Seat | null)[] = [];
        let seatNumber = 1;
        for (let col = 1; col <= 15; col++) {
          if (col === 8) {
            currentRow.push(null); 
          } else {
            currentRow.push({
              id: `${String.fromCharCode(65 + row)}${seatNumber++}`,
              isBooked: false,
            });
          }
        }
        layout.push(currentRow);
      }
    } else if (theaterId === '2') {
      for (let row = 0; row < 10; row++) {
        let currentRow: (Seat | null)[] = [];
        let seatNumber = 1;
        for (let col = 1; col <= 20; col++) {
          if (col === 11) {
            currentRow.push(null); 
          } else {
            currentRow.push({
              id: `${String.fromCharCode(65 + row)}${seatNumber++}`,
              isBooked: false,
            });
          }
        }
        layout.push(currentRow);
      }
    } else if (theaterId === '3') {
      for (let row = 0; row < 12; row++) {
        let currentRow: (Seat | null)[] = [];
        let seatNumber = 1;
        for (let col = 1; col <= 25; col++) {
          if (col === 9 || col === 18) {
            currentRow.push(null); 
          } else {
            currentRow.push({
              id: `${String.fromCharCode(65 + row)}${seatNumber++}`,
              isBooked: false,
            });
          }
        }
        layout.push(currentRow);
      }
    }
  
    setSeatsLayout(layout);
  };
  

  const toggleSeat = (seatId: string) => {
    setSelectedSeats(prev =>
      prev.includes(seatId) ? prev.filter(id => id !== seatId) : [...prev, seatId]
    );
  };

  const renderSeats = () => {
    if (seatsLayout.length === 0) return <Text style={{ color: 'white' }}>No seats available.</Text>;

    return seatsLayout.map((row, rowIndex) => (
      <View key={rowIndex} style={styles.row}>
        <Text style={styles.rowLabel}>{String.fromCharCode(65 + rowIndex)}</Text>
        <View style={styles.seatRow}>
          {row.map((seat, index) => {
            if (seat === null) {
              return <View key={`space-${index}`} style={styles.space} />;
            }
            return (
              <Pressable
                key={seat.id}
                onPress={() => toggleSeat(seat.id)}
                style={[
                  styles.seat,
                  seat.isBooked
                    ? styles.seatBooked
                    : selectedSeats.includes(seat.id)
                    ? styles.seatSelected
                    : styles.seatAvailable,
                ]}
              >
                <Text style={styles.seatText}>
                  {seat.id.replace(/^[A-Z]/, '')}
                </Text>
              </Pressable>
            );
          })}
        </View>
      </View>
    ));
  };

  return (
    <ScrollView 
      contentContainerStyle={styles.container}
      maximumZoomScale={3}
      minimumZoomScale={1}
      showsVerticalScrollIndicator={false}
    >
      <View style={styles.screen}>
        <Text style={styles.screenText}>SCREEN</Text>
      </View>

      <ScrollView horizontal showsHorizontalScrollIndicator={true}>
        <View style={styles.seatsArea}>
          {renderSeats()}
        </View>
      </ScrollView>

      <View style={styles.legendContainer}>
        <View style={styles.legendItem}>
          <View style={[styles.legendBox, { backgroundColor: '#1e293b' }]} />
          <Text style={styles.legendText}>Available</Text>
        </View>
        <View style={styles.legendItem}>
          <View style={[styles.legendBox, { backgroundColor: '#444' }]} />
          <Text style={styles.legendText}>Booked</Text>
        </View>
        <View style={styles.legendItem}>
          <View style={[styles.legendBox, { backgroundColor: '#a800b7' }]} />
          <Text style={styles.legendText}>Selected</Text>
        </View>
      </View>

      <TouchableOpacity style={styles.reserveButton}>
        <Text style={styles.reserveText}>Add to Cart</Text>
      </TouchableOpacity>
    </ScrollView>
  );
}

const styles = StyleSheet.create({
  container: {
    paddingTop: 20,
    paddingBottom: 40,
    alignItems: 'center',
    backgroundColor: '#121212',
    minHeight: '100%',
  },
  screen: {
    width: '70%',
    height: 30,
    marginBottom: 30,
    backgroundColor: '#aaa',
    borderRadius: 15,
    justifyContent: 'center',
    alignItems: 'center',
    shadowColor: '#000',
    shadowOpacity: 0.4,
    shadowRadius: 5,
  },
  screenText: {
    fontWeight: 'bold',
    color: '#1a1a1a',
    letterSpacing: 1,
  },
  seatsArea: {
    alignItems: 'center',
  },
  row: {
    flexDirection: 'row',
    alignItems: 'center',
    marginBottom: 10,
  },
  rowLabel: {
    width: 20,
    marginRight: 8,
    color: '#fff',
    fontWeight: 'bold',
    fontSize: 12,
    textAlign: 'center',
  },
  seatRow: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  seat: {
    width: 28,
    height: 28,
    marginHorizontal: 2,
    marginVertical: 4,
    borderRadius: 6,
    justifyContent: 'center',
    alignItems: 'center',
  },
  seatAvailable: {
    backgroundColor: '#1e293b',
  },
  seatBooked: {
    backgroundColor: '#444',
    opacity: 0.5,
  },
  seatSelected: {
    backgroundColor: '#a800b7',
  },
  seatText: {
    color: '#fff',
    fontSize: 8,
    fontWeight: 'bold',
  },
  space: {
    width: 20,
    height: 20,
    marginHorizontal: 6,
  },
  legendContainer: {
    flexDirection: 'row',
    marginTop: 30,
    marginBottom: 20,
    gap: 20,
    justifyContent: 'center',
  },
  legendItem: {
    alignItems: 'center',
  },
  legendBox: {
    width: 20,
    height: 20,
    borderRadius: 5,
    marginBottom: 4,
  },
  legendText: {
    color: '#ccc',
    fontSize: 12,
  },
  reserveButton: {
    backgroundColor: '#a800b7',
    paddingVertical: 14,
    paddingHorizontal: 30,
    borderRadius: 8,
    marginTop: 10,
  },
  reserveText: {
    color: '#fff',
    fontWeight: 'bold',
    fontSize: 16,
  },
});
