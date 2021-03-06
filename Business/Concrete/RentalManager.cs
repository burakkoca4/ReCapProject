using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalService _rentalService;
        public RentalManager(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate==null)
            {
                return new ErrorResult(Messages.RentalAddedError);
            }
            _rentalService.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }
    }
}
