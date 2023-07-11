
using System;
using System.Collections.Generic;

namespace CleanCode.LongParameterList
{
    public class DateRange
    {
        private DateTime _dateFrom;
        private DateTime _dateTo;

        public DateRange(DateTime dateFrom, DateTime dateTo)
        {
            _dateFrom = dateFrom;
            _dateTo = dateTo;
        }

        public DateTime DateFrom { get { return _dateFrom; } }

        public DateTime DateTo { get { return _dateTo; } }
	}

    public class ReservationQuery
    {
        private DateRange _dateRange;
        private User _user;
        private int _location;
        private LocationType _locationType;
        private int? _customerId;

        public ReservationQuery(DateRange dateRange, User user, int location, LocationType locationType, int? customerId)
        {
            _dateRange = dateRange;
            _user = user;
            _location = location;
            _locationType = locationType;
            _customerId = customerId;
        }

        public DateRange DateRange { get { return _dateRange; } }
        public User User { get { return _user; } }

        public int Location { get { return _location; } }
        public LocationType LocationType { get { return _locationType; } }

        public int? Customer { get { return _customerId; } }

	}


    public class LongParameterList
    {
        public IEnumerable<Reservation> GetReservations(ReservationQuery query)
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (query.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetUpcomingReservations(
            ReservationQuery query)
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (query.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(DateRange dateRange, ReservationDefinition sd)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(ReservationQuery query)
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (query.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }
    }

    internal class ReservationDefinition
    {
    }

    public class LocationType
    {
    }

    public class User
    {
        public object Id { get; set; }
    }

    public class Reservation
    {
    }
}
