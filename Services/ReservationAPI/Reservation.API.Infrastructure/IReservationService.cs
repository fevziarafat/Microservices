using System;
using Reservation.API.Models;

namespace Reservation.API.Infrastructure
{
	public interface IReservationService
	{
		public ReservationDTO GetResByBkgNumber(int BkgNumber);
	}
}
