import { useState, useEffect} from "react";
import "./SeatSelector.css";
import { Seat } from "./types";
import { useSelectedTheater } from "./Location/LocationContext";

export default function SeatSelector(){
  const { theater } = useSelectedTheater();
  const [seatsLayout, setSeatsLayout] = useState<(Seat | null)[][]>([]);
  const [selectedSeats, setSelectedSeats] = useState<string[]>([]);

  useEffect(() => {
    if (theater && theater.theaterId) {
      generateSeatsForTheater(theater.theaterId.toString());
    }
  }, [theater]);

  const generateSeatsForTheater = (theaterId: string) => {
    let layout: (Seat | null)[][] = [];

    if (theaterId === "1") {
      for (let row = 0; row < 10; row++) {
        let currentRow: (Seat | null)[] = [];
        let seatNumber = 1;
        for (let col = 1; col <= 15; col++) {
          if (col === 8) {
            currentRow.push(null);
          } else {
            currentRow.push({
              id: `${String.fromCharCode(65 + row)}${seatNumber++}`,
              isBooked: Math.random() > 0.8, // Random bookings for demo
            });
          }
        }
        layout.push(currentRow);
      }
    } else if (theaterId === "2") {
      for (let row = 0; row < 10; row++) {
        let currentRow: (Seat | null)[] = [];
        let seatNumber = 1;
        for (let col = 1; col <= 20; col++) {
          if (col === 11) {
            currentRow.push(null);
          } else {
            currentRow.push({
              id: `${String.fromCharCode(65 + row)}${seatNumber++}`,
              isBooked: Math.random() > 0.8,
            });
          }
        }
        layout.push(currentRow);
      }
    } else if (theaterId === "3") {
      for (let row = 0; row < 12; row++) {
        let currentRow: (Seat | null)[] = [];
        let seatNumber = 1;
        for (let col = 1; col <= 25; col++) {
          if (col === 9 || col === 18) {
            currentRow.push(null);
          } else {
            currentRow.push({
              id: `${String.fromCharCode(65 + row)}${seatNumber++}`,
              isBooked: Math.random() > 0.8,
            });
          }
        }
        layout.push(currentRow);
      }
    }
    setSeatsLayout(layout);
  }

    const toggleSeat = (seatId: string, isBooked: boolean) => {
      if (isBooked) return; // Don't allow selection of booked seats

      setSelectedSeats((prev) =>
        prev.includes(seatId)
          ? prev.filter((id) => id !== seatId)
          : [...prev, seatId]
      );
    };

    const renderSeats = () => {
      if (!theater) {
        return <div className="no-theater">Please select a theater first.</div>;
      }
      if (seatsLayout.length === 0) {
        return (
          <div className="no-seats">
            No seats available for {theater.theaterName}.
          </div>
        );
      }

      return seatsLayout.map((row, rowIndex) => (
        <div key={rowIndex} className="row">
          <div className="row-label">{String.fromCharCode(65 + rowIndex)}</div>
          <div className="seat-row">
            {row.map((seat, index) => {
              if (seat === null) {
                return <div key={`space-${index}`} className="space" />;
              }
              return (
                <div
                  key={seat.id}
                  onClick={() => toggleSeat(seat.id, seat.isBooked)}
                  className={`seat ${
                    seat.isBooked
                      ? "seat-booked"
                      : selectedSeats.includes(seat.id)
                      ? "seat-selected"
                      : "seat-available"
                  }`}
                >
                  <span className="seat-text">
                    {seat.id.replace(/^[A-Z]/, "")}
                  </span>
                </div>
              );
            })}
          </div>
        </div>
      ));
    };

    return (
      <>
      <div className="seat-selector-container">
        {theater && (
          <div className="theater-info">
            <h2>{theater.theaterName}</h2>
          </div>
        )}

        <div className="screen">
          <div className="screen-text">SCREEN</div>
        </div>

        <div className="seats-area-container">
          <div className="seats-area">{renderSeats()}</div>
        </div>

        <div className="legend-container">
          <div className="legend-item">
            <div className="legend-box available" />
            <div className="legend-text">Available</div>
          </div>
          <div className="legend-item">
            <div className="legend-box booked" />
            <div className="legend-text">Booked</div>
          </div>
          <div className="legend-item">
            <div className="legend-box selected" />
            <div className="legend-text">Selected</div>
          </div>
        </div>

        {selectedSeats.length > 0 && (
          <div className="selected-seats-info">
            Selected seats: {selectedSeats.join(", ")}
          </div>
        )}

        <button
          className={`reserve-button ${
            selectedSeats.length === 0 ? "disabled" : ""
          }`}
          disabled={selectedSeats.length === 0}
        >
          Add to Cart {selectedSeats.length > 0 && `(${selectedSeats.length})`}
        </button>
      </div>
      </>
    );
  };

