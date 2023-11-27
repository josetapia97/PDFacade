using FacadeTravelAgency.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTravelAgency
{
    public class TravelFacade
    {
        private CarRental _car;
        private FlighBooking _flight;
        private HotelBooking _hotel;
        public TravelFacade(CarRental car, FlighBooking flight, HotelBooking hotel)
        {
            _car = car;
            _flight = flight;
            _hotel = hotel;
        }

        public void ArrangeTrip(string Country)
        {
            _car.RentCar(Country);
            _flight.BookFlight(Country);
            _hotel.BookHotel(Country);
        }
    }
}
