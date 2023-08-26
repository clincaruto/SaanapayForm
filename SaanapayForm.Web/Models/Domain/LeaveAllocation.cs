using System.ComponentModel.DataAnnotations.Schema;

namespace SaanapayForm.Web.Models.Domain
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public string EmployeeId { get; set; }
        public int Period { get; set; }

        // Navigation properties
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }

    }
}
