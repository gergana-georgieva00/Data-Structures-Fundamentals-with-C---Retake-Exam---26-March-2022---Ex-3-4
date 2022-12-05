using System;
using System.Collections.Generic;
using System.Linq;

namespace TripAdministrations
{
    public class TripAdministrator : ITripAdministrator
    {
        private List<Company> companies;
        private List<Trip> trips;
        private Dictionary<Company, List<Trip>> companyTrips;

        public TripAdministrator()
        {
            this.companies = new List<Company>();
            this.trips = new List<Trip>();
            companyTrips = new Dictionary<Company, List<Trip>>();
        }

        public void AddCompany(Company c)
        {
            if (this.companies.Any(co => co.Name == c.Name))
            {
                throw new ArgumentException();
            }

            this.companies.Add(c);
            this.companyTrips.Add(c, new List<Trip>());
        }

        public void AddTrip(Company c, Trip t)
        {
            if (!this.companies.Contains(c))
            {
                throw new ArgumentException();
            }

            this.trips.Add(t);
            companyTrips[c].Add(t);
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

            var tripsToRemove = c.Trips;
            this.companies.Remove(c);
            foreach (var trip in tripsToRemove)
            {
                trips.Remove(trip);
            }
        }

        public IEnumerable<Company> GetCompanies()
            => this.companies;

        public IEnumerable<Trip> GetTrips()
            => this.trips;

        public void ExecuteTrip(Company c, Trip t)
        {
            if (!this.companies.Contains(c))
            {
                throw new ArgumentException();
            }
            if (!this.trips.Contains(t))
            {
                throw new ArgumentException();
            }
            if (!c.Trips.Contains(t))
            {
                throw new ArgumentException();
            }

            c.Trips.Remove(t);
            trips.Remove(t);
        }

        public IEnumerable<Company> GetCompaniesWithMoreThatNTrips(int n)
            => this.companies.Where(c => c.Trips.Count > n);

        public IEnumerable<Trip> GetTripsWithTransportationType(Transportation t)
        {
            return this.trips.Where(t => t.Transportation.CompareTo(t) == 0);
        }

        public IEnumerable<Trip> GetAllTripsInPriceRange(int lo, int hi)
            => this.trips.Where(t => t.Price >= lo && t.Price <= hi);
    }
}
