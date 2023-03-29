using SaanapayForm.Web.Data;
using SaanapayForm.Web.GenericRepository.IRepository;
using SaanapayForm.Web.Models.Domain;

namespace SaanapayForm.Web.GenericRepository.Repository
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
