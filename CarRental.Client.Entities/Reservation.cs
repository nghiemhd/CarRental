using Core.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Client.Entities
{
    public class Reservation : ObjectBase
    {
        int reservationId;
        int accountId;
        int carId;
        DateTime returnDate;
        DateTime rentalDate;

        public int ReservationId
        {
            get { return reservationId; }
            set
            {
                if (reservationId != value)
                {
                    reservationId = value;
                    OnPropertyChanged(() => ReservationId);
                }
            }
        }

        public int AccountId
        {
            get { return accountId; }
            set
            {
                if (accountId != value)
                {
                    accountId = value;
                    OnPropertyChanged(() => AccountId);
                }
            }
        }

        public int CarId
        {
            get { return carId; }
            set
            {
                if (carId != value)
                {
                    carId = value;
                    OnPropertyChanged(() => CarId);
                }
            }
        }

        public DateTime RentalDate
        {
            get { return rentalDate; }
            set
            {
                if (rentalDate != value)
                {
                    rentalDate = value;
                    OnPropertyChanged(() => RentalDate);
                }
            }
        }

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set
            {
                if (returnDate != value)
                {
                    returnDate = value;
                    OnPropertyChanged(() => ReturnDate);
                }
            }
        }
    }
}
