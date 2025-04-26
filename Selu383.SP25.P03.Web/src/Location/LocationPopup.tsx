import React, { useEffect, useState } from "react";
import { theaters } from "./theaters";
import { getDistance } from "./distance";
import "./LocationPopup.css";

type Theater = {
  name: string;
  address: string;
  lat: number;
  lon: number;
};

type NearbyTheater = {
  name: string;
  address: string;
  distance: number;
};

const LocationPopup: React.FC = () => {
  const [userCoords, setUserCoords] = useState<{ lat: number; lon: number } | null>(null);
  const [nearbyTheaters, setNearbyTheaters] = useState<NearbyTheater[]>([]);
  const [error, setError] = useState<string>("");

  useEffect(() => {
    if ("geolocation" in navigator) {
      navigator.geolocation.getCurrentPosition(
        (position) => {
          const lat = position.coords.latitude;
          const lon = position.coords.longitude;
          setUserCoords({ lat, lon });

          const sorted = (theaters as Theater[])
            .map((theater): NearbyTheater => ({
              name: theater.name,
              address: theater.address,
              distance: getDistance(lat, lon, theater.lat, theater.lon),
            }))
            .sort((a: NearbyTheater, b: NearbyTheater) => a.distance - b.distance)
            .slice(0, 3); // Top 3 closest theaters

          setNearbyTheaters(sorted);
          console.log("Works")
        },
        () => {
          setError("Location permission denied or unavailable.");
          console.log("not working");
        }
      );
    } else {
      setError("Geolocation is not supported in this browser.");
      console.log("not working");
    }
  }, []);

  return (
    <div className="popup-content">
      <h2>🎬 Theaters Near You</h2>

      {error && <p>{error}</p>}

      {!userCoords || nearbyTheaters.length === 0 ? (
        <p>Detecting your location...</p>
      ) : (
        nearbyTheaters.map((theater, index) => (
          <div key={index} className="theater-card">
            <h3>{theater.name}</h3>
            <p>{theater.address}</p>
            <p><span className="pin-icon"></span>{theater.distance.toFixed(2)} miles away</p>
          </div>
        ))
      )}
    </div>
  );
};

export default LocationPopup;
