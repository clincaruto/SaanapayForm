namespace SaanapayForm.Web.Models.Domain
{
    public class RequisitionForm : BaseEntity
    {
        //public string EmployeeId { get; set; }
        // public int EmployeeId { get; set; }
        public string? RequisitionName { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
        public int Amount { get; set; }
    }
}
