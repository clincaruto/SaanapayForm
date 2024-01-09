using System.ComponentModel.DataAnnotations;

namespace SaanapayForm.Web.Models.ViewModel
{
    public class AdminLeaveRequestVM
    {
        [Display(Name = "Total Number Of Requests")]
        public int TotalRequests { get; set; }

        [Display(Name = "Approved Requests")]
        public int ApprovedRequests { get; set; }

        [Display(Name = "Pending Requests")]
        public int PendingRequests { get; set; }

        [Display(Name = "Rejected Requests")]
        public int RejectRequests { get; set; }

        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}
