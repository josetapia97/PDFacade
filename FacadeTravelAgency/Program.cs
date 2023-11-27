using FacadeTravelAgency;
using FacadeTravelAgency.Subsystems;

CarRental autitos = new CarRental();
FlighBooking vuelo = new FlighBooking();
HotelBooking hotel = new HotelBooking();

TravelFacade Agencia = new TravelFacade(autitos,vuelo,hotel);

Agencia.ArrangeTrip("Chile");