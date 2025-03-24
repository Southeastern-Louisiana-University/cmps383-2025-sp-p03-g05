
import React, { useState } from 'react';


const CitySelector = () => {
  const [selectedCity, setSelectedCity] = useState<string | null>(null);

  const cities = [
    'New Orleans',
    'Baton Rouge',
    'Lafayette',
    'Shreveport',
    'Lake Charles',
    'Monroe',
    'Alexandria',
    'Houma',
    'Kenner',
    'Bossier City',
  ];

  const handleCityChange = (event: React.ChangeEvent<HTMLSelectElement>) => {
    setSelectedCity(event.target.value);
  };

  return (
    <div className="city-selector-container">
      <h2 className="city-selector-title">Select a City</h2>
      <div className="city-selector-box">
        <select className="city-selector" onChange={handleCityChange}>
          <option value="">-- Choose a City --</option>
          {cities.map((city, index) => (
            <option key={index} value={city}>
              {city}
            </option>
          ))}
        </select>
      </div>
      {selectedCity && <p className="city-message">You selected: {selectedCity}</p>}
    </div>
  );
};

export default CitySelector;
