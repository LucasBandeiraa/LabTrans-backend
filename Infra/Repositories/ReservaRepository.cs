using Domain.Entities;
using Domain.Interfaces;
using Infra.Data;

namespace LabTrans.Infra.Repositories
{
    public class ReservaRepository : GenericRepository<Reserva> , IReservaRepository
    {
        public ReservaRepository(LabTransContext context) : base(context)
        {

        }
    }
}
