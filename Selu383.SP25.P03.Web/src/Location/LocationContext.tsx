import { createContext, useContext, useState } from "react";

//RENAME TO THEATERS
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

export const SelectedTheaterContext = createContext<SelectedTheaterContextValue>(
  DefaultSelectedTheaterContextValue
);

export const useSelectedTheater = () => 
    useContext(SelectedTheaterContext);

export const SelectedTheaterProvider = ({ children }: React.PropsWithChildren) => {
  const [location, setSelectedTheater] = useState<SelectedTheater | null >(null);

  return (
    <SelectedTheaterContext.Provider value={{ theater: location, setSelectedTheater }}>
      {children}
    </SelectedTheaterContext.Provider>
  );
};
