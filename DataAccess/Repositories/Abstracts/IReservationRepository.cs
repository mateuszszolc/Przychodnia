using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repositories.Abstracts
{
    public interface IReservationRepository:IRepository<Reservation>
    {
        public Task<List<Reservation>> GetAllReservations();
        Task<Reservation> AddReservationAsync(Reservation reservation);

        public Task<Reservation> UpdateReservationAsync(Reservation entity);

        Task<Reservation> RemoveReservationAsync(Reservation userRole);
        List<Reservation> GetAllReservationsByUserIdAsync(int userId);
    }
}