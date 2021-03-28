using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.Repositories.Abstracts;
using Service.Abstracts;

namespace Service
{
  public class ReservationService:IReservationService
  {
      private readonly IReservationRepository _reservationRepository;
        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<List<Reservation>> GetAllReservations()
        {
           return await _reservationRepository.GetAllReservations();
        }
        public  List<Reservation> GetAllReservationsByUserIdAsync(int userId)
        {
            return  _reservationRepository.GetAllReservationsByUserIdAsync(userId);
        }
        public async Task<Reservation> AddReservationAsync(Reservation reservation)
        {
            return await _reservationRepository.AddReservationAsync(reservation);

        }
        public async Task<Reservation> UpdateReservationAsync(Reservation reservation)
        {
            return await _reservationRepository.UpdateReservationAsync(reservation);

        }
        public async Task<Reservation> RemoveReservationAsync(Reservation reservation)
        {
            return await _reservationRepository.RemoveReservationAsync(reservation);

        }
    }
}
