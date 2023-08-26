using AutoMapper;
using SaanapayForm.Web.Models.Domain;
using SaanapayForm.Web.Models.ViewModel;

namespace SaanapayForm.Web.Configurations.Profiles
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<RequisitionForm, RequisitionFormVM>().ReverseMap();
            CreateMap<Employee, EmployeeListVM>().ReverseMap(); 
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationEditVM>().ReverseMap();

        }
    }
}
