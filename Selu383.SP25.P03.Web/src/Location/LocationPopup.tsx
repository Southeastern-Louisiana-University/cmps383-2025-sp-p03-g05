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
            .slice(0, 3); // Show top 3 closest

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

  if (error) {
    return <div className="popup-content"><p>{error}</p></div>;
  }

  if (!userCoords || nearbyTheaters.length === 0) {
    return <div className="popup-content"><p>Detecting your location...</p></div>;
  }

  return (
    <div className="popup-content">
      <h2>🎬 Theaters Near You</h2>
      {nearbyTheaters.map((theater, index) => (
        <div key={index} className="theater-card">
          <h3>{theater.name}</h3>
          <p>{theater.address}</p>
          <p>📍 {theater.distance.toFixed(2)} km away</p>
        </div>
      ))}
    </div>
  );
};

export default LocationPopup;
