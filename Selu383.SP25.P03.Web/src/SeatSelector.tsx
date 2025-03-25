import React, { useState } from 'react';
import './SeatSelector.css';

type Seat = {
  id: string;
  isBooked: boolean;
};

const generateSeats = (rows: number, cols: number): Seat[] => {
  const seats: Seat[] = [];
  for (let r = 0; r < rows; r++) {
    for (let c = 0; c < cols; c++) {
      seats.push({
        id: `${String.fromCharCode(65 + r)}${c + 1}`,
        isBooked: Math.random() < 0.2,
      });
    }
  }
  return seats;
};

const SeatSelector: React.FC = () => {
    const [seats] = useState<Seat[]>(generateSeats(10, 12)); 
    const [selectedSeats, setSelectedSeats] = useState<string[]>([]);

  const toggleSeat = (seatId: string) => {
    setSelectedSeats((prev) =>
      prev.includes(seatId)
        ? prev.filter((id) => id !== seatId)
        : [...prev, seatId]
    );
  };

  return (
    <div className="theater-container">
      <div className="screen">SCREEN</div>
  
      <div className="seats-container">
        {seats.map((seat) => (
          <div
            key={seat.id}
            className={`seat ${seat.isBooked ? 'booked' : ''} ${
              selectedSeats.includes(seat.id) ? 'selected' : ''
            }`}
            onClick={() => !seat.isBooked && toggleSeat(seat.id)}
            title={seat.id}
          >
            {seat.id}
          </div>
        ))}
      </div>
  
      <div className="legend">
        <div className="legend-item">
          <div className="legend-box available"></div> Available
        </div>
        <div className="legend-item">
          <div className="legend-box booked"></div> Booked
        </div>
        <div className="legend-item">
          <div className="legend-box selected"></div> Selected
        </div>
      </div>
    </div>
  );
  
};

export default SeatSelector;
