export type Movie = {
  id: number;
  title: string;
  genre: string;
  year: number;
  ageRating: string;
  poster: string;
  description: string;
};

export type Theater = {
  id: number;
  name: string;
  address: string;
  seatCount: number;
  managerId: number;
  showtimes: Array<Showtime>;
};

export type Showtime = {
  id: number;
  startTime: string;
  movieId: number;
  theaterId: number;
  format: string;
  available: boolean;
};

export type ComingSoon = {
  id: number;
  title: string;
  genre: string;
  releaseYear: number;
  ageRating: string;
  poster: string;
  description: string;
};

export type Seat = {
  id: string;
  isBooked: boolean;
};
