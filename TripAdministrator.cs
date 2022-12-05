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
            if (!this.companies.Contains(c))
            {
                throw new ArgumentException();
            }

            c.Trips.Add(t);
        }

        public bool Exist(Company c)
            => this.companies.Contains(c);

        public bool Exist(Trip t)
            => this.trips.Contains(t);

        public void RemoveCompany(Company c)
        {
            if (!this.companies.Contains(c))
            {
                throw new ArgumentException();
            }

            this.companies.Remove(c);
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
