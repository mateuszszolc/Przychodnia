using DataAccess.Models;
using DataAccess.Models.Context;
using DataAccess.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public async Task<List<Reservation>> GetAllReservations()
        {
            return await GetAll().ToListAsync();

        }
        public List<Reservation> GetAllReservationsByUserIdAsync(int userId)
        {
            return  GetAll().FirstOrDefault(x => x.User.UserId == userId).User.Reservations.ToList();
        }

        public async Task<Reservation> AddReservationAsync(Reservation reservation)
        {
            return await AddAsync(reservation);
           
        }
        public async Task<Reservation> UpdateReservationAsync(Reservation reservation)
        {
            return await UpdateAsync(reservation);
           
        }
        public async Task<Reservation> RemoveReservationAsync(Reservation reservation)
        {
           return await DeleteAsync(reservation);
        }
    }
}
