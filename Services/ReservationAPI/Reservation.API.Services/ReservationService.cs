using System;
using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Services
{
	public class ReservationService: IReservationService
	{
		public ReservationDTO GetResByBkgNumber(int BkgNumber)
		{
			return new ReservationDTO()
			{
				Amount = new Random().Next(10000),
				Id = new Random().Next(100),
				BkgDate = DateTime.Now,
				CheckInDate = DateTime.Now.AddDays(30),
				CheckOutDate = DateTime.Now.AddDays(37),
				BkgNumber= BkgNumber
			};
		}
	}
}
