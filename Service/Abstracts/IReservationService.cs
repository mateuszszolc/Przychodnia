using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace Service.Abstracts
{
    public interface IReservationService
    {
        public Task<List<Reservation>> GetAllReservations();
        Task<Reservation> AddReservationAsync(Reservation reservation);

        public Task<Reservation> UpdateReservationAsync(Reservation entity);

        Task<Reservation> RemoveReservationAsync(Reservation userRole);
        List<Reservation> GetAllReservationsByUserIdAsync(int userId);
    }
}