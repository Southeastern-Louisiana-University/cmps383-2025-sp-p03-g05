import React, { useEffect, useState } from 'react';
import { View, Text, StyleSheet, TouchableOpacity, ScrollView } from 'react-native';
import { useLocalSearchParams, useRouter } from 'expo-router';


interface Seat {
  id: number;
  row: string;
  col: number;
  isTaken: boolean;
}


export default function SeatSelector() {
  const { theaterId } = useLocalSearchParams();
  const [seats, setSeats] = useState<Seat[] | null>(null);
  const [selectedSeats, setSelectedSeats] = useState<number[]>([]);
  const router = useRouter();


  useEffect(() => {
    const fetchSeats = async () => {
      try {
        const response = await fetch(`https://selu383-sp25-p03-g05.azurewebsites.net/api/seats/${theaterId}`);
        const data = await response.json();
        console.log("Fetched seats:", data);
        setSeats(data);
      } catch (error) {
        console.error('Failed to fetch seats:', error);
      }
    };
    if (theaterId) {
      fetchSeats();
    }
  }, [theaterId]);


  const toggleSeat = (seatId: number) => {
    setSelectedSeats(prev =>
      prev.includes(seatId) ? prev.filter(id => id !== seatId) : [...prev, seatId]
    );
  };


  const renderRows = () => {
    if (!Array.isArray(seats)) {
      return (
        <Text style={{ color: 'white' }}>No seat data found for this theater.</Text>
      );
    }


    const rows = Array.from(new Set(seats.map(seat => seat.row)));
    return rows.map(row => (
      <View key={row} style={styles.row}>
        <Text style={styles.rowLabel}>{row}</Text>
        <View style={styles.rowSeats}>
          {seats
            .filter(seat => seat.row === row)
            .sort((a, b) => a.col - b.col)
            .map(seat => (
              <TouchableOpacity
                key={seat.id}
                onPress={() => !seat.isTaken && toggleSeat(seat.id)}
                style={[styles.seat,
                  seat.isTaken ? styles.seatTaken : selectedSeats.includes(seat.id) ? styles.seatSelected : styles.seatAvailable]}
              >
                <Text style={styles.seatText}>{seat.col}</Text>
              </TouchableOpacity>
            ))}
        </View>
      </View>
    ));
  };


  const handleReserve = async () => {
    try {
      const response = await fetch('https://selu383-sp25-p03-g05.azurewebsites.net/api/seats/reserve', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(selectedSeats),
      });
      const result = await response.json();
      alert(result.message);
      setSelectedSeats([]);
    } catch (error) {
      alert('Reservation failed.');
      console.error(error);
    }
  };


  return (
    <ScrollView contentContainerStyle={styles.container}>
      <Text style={styles.title}>Select Your Seats</Text>
      {renderRows()}
      <TouchableOpacity style={styles.reserveButton} onPress={handleReserve}>
        <Text style={styles.reserveText}>Confirm Reservation</Text>
      </TouchableOpacity>
    </ScrollView>
  );
}


const PURPLE = '#a800b7';
const GRAY = '#9e9e9e';
const GREEN = '#4caf50';
const ORANGE = '#ff9800';


const styles = StyleSheet.create({
  container: {
    padding: 20,
    alignItems: 'center',
    backgroundColor: '#000',
  },
  title: {
    fontSize: 24,
    fontWeight: 'bold',
    marginBottom: 20,
    color: '#fff',
  },
  row: {
    flexDirection: 'row',
    alignItems: 'center',
    marginBottom: 12,
  },
  rowLabel: {
    width: 20,
    marginRight: 8,
    fontWeight: 'bold',
    color: '#fff',
  },
  rowSeats: {
    flexDirection: 'row',
    flexWrap: 'wrap',
  },
  seat: {
    width: 30,
    height: 30,
    margin: 4,
    alignItems: 'center',
    justifyContent: 'center',
    borderRadius: 4,
  },
  seatAvailable: {
    backgroundColor: GREEN,
  },
  seatTaken: {
    backgroundColor: GRAY,
  },
  seatSelected: {
    backgroundColor: ORANGE,
  },
  seatText: {
    color: '#fff',
    fontSize: 12,
  },
  reserveButton: {
    backgroundColor: PURPLE,
    paddingVertical: 12,
    paddingHorizontal: 20,
    borderRadius: 6,
    marginTop: 30,
  },
  reserveText: {
    color: '#fff',
    fontWeight: 'bold',
    fontSize: 16,
  },
});


