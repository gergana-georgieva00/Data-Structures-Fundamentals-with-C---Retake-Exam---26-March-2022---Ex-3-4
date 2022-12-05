using System;
using System.Collections.Generic;
using System.Linq;

namespace TripAdministrations
{
    public class TripAdministrator : ITripAdministrator
    {
        private List<Company> companies;
        private List<Trip> trips;

        public TripAdministrator()
        {
            this.companies = new List<Company>();
            this.trips = new List<Trip>();
        }

        public void AddCompany(Company c)
        {
            if (this.companies.Any(co => co.Name == c.Name))
            {
                throw new ArgumentException();
            }

            this.companies.Add(c);
        }

        public void AddTrip(Company c, Trip t)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Company c)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Trip t)
        {
            throw new NotImplementedException();
        }

        public void RemoveCompany(Company c)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetCompanies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trip> GetTrips()
        {
            throw new NotImplementedException();
        }

        public void ExecuteTrip(Company c, Trip t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetCompaniesWithMoreThatNTrips(int n)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trip> GetTripsWithTransportationType(Transportation t)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trip> GetAllTripsInPriceRange(int lo, int hi)
        {
            throw new NotImplementedException();
        }
    }
}
