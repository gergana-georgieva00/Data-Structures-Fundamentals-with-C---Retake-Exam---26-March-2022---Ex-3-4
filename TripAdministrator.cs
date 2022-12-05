﻿using System;
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
            this.trips.Add(t);
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
        }

        public IEnumerable<Company> GetCompaniesWithMoreThatNTrips(int n)
            => this.companies.Where(c => c.Trips.Count > n);

        public IEnumerable<Trip> GetTripsWithTransportationType(Transportation t)
            => this.trips.Where(t => t.Transportation.Equals(t));

        public IEnumerable<Trip> GetAllTripsInPriceRange(int lo, int hi)
            => this.trips.Where(t => t.Price >= lo && t.Price <= hi);
    }
}
