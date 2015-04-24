using Core.Common.Core;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Client.Entities
{
    public class Car : ObjectBase
    {
        int carId;
        string description;
        string color;
        int year;
        decimal rentalPrice;
        bool currentlyRented;

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

        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged(() => Description);
                }
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (color != value)
                {
                    color = value;
                    OnPropertyChanged(() => Color);
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (year != value)
                {
                    year = value;
                    OnPropertyChanged(() => Year);
                }
            }
        }

        public decimal RentalPrice
        {
            get { return rentalPrice; }
            set
            {
                if (rentalPrice != value)
                {
                    rentalPrice = value;
                    OnPropertyChanged(() => RentalPrice);
                }
            }
        }

        public bool CurrentlyRented
        {
            get { return currentlyRented; }
            set
            {
                if (currentlyRented != value)
                {
                    currentlyRented = value;
                    OnPropertyChanged(() => CurrentlyRented);
                }
            }
        }

        public string LongDescription
        {
            get
            {
                return string.Format("{0} {1} {2}", year, color, description);
            }
        }

        class CarValidator : AbstractValidator<Car>
        {
            public CarValidator()
            {
                RuleFor(p => p.Description).NotEmpty();
                RuleFor(p => p.Color).NotEmpty();
                RuleFor(p => p.RentalPrice).GreaterThan(0);
                RuleFor(p => p.Year).GreaterThan(2000).LessThanOrEqualTo(DateTime.Now.Year + 1);
            }
        }

        protected override IValidator GetValidator()
        {
            return new CarValidator();
        }
    }
}
