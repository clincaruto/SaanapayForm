using SaanapayForm.Web.Data;
using SaanapayForm.Web.GenericRepository.IRepository;
using SaanapayForm.Web.Models.Domain;

namespace SaanapayForm.Web.GenericRepository.Repository
{
    public class RequisitionRepository : GenericRepository<RequisitionForm>, IRequisitionRepository
    {
        public RequisitionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
