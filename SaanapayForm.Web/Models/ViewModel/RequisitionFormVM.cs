using System.ComponentModel.DataAnnotations;

namespace SaanapayForm.Web.Models.ViewModel
{
    public class RequisitionFormVM
    {
        public int Id { get; set; }
      //  public string? EmployeeId { get; set; }
        // public int EmployeeId { get; set; }
        [Required(ErrorMessage = "This Field can not be empty")]
        public string? RequisitionName { get; set; }
        [Required(ErrorMessage = "This Field can not be empty")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "This Field can not be empty")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "This Field can not be empty")]
        public int Rate { get; set; }

        [Required(ErrorMessage = "This Field can not be empty")]
        public int Amount { get; set; }
    }
}
