import { createContext, useContext, useEffect, useState } from "react";

interface SelectedTheater {
  theaterName: string;
  theaterId: number;
}
interface SelectedTheaterContextValue {
  setSelectedTheater: (location: SelectedTheater | null) => void;
  theater: SelectedTheater | null;
}

const DefaultSelectedTheaterContextValue: SelectedTheaterContextValue = {
  theater: null,
  setSelectedTheater: () => {},
};

export const SelectedTheaterContext =
  createContext<SelectedTheaterContextValue>(
    DefaultSelectedTheaterContextValue
  );

export const useSelectedTheater = () => useContext(SelectedTheaterContext);

export const SelectedTheaterProvider = ({
  children,
}: React.PropsWithChildren) => {
  const [location, setLocationState] = useState<SelectedTheater | null>(null);

  useEffect(() => {
    const stored = localStorage.getItem("selectedTheater");
    if (stored) {
      const parsed = JSON.parse(stored);
      setLocationState(parsed);
    }
  }, []);

  const setSelectedTheater = (location: SelectedTheater | null) => {
    if (location) {
      localStorage.setItem("selectedTheater", JSON.stringify(location));
    }
    else {
      localStorage.removeItem("selectedTheater");
    }
    setLocationState(location);
  }

  return (
    <SelectedTheaterContext.Provider
      value={{ theater: location, setSelectedTheater }}
    >
      {children}
    </SelectedTheaterContext.Provider>
  );
};
