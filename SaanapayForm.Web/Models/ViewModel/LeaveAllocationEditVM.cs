﻿namespace SaanapayForm.Web.Models.ViewModel
{
	public class LeaveAllocationEditVM : LeaveAllocationVM
	{
		public string EmployeeId { get; set; }
		public int LeaveTypeId { get; set; }
		public EmployeeListVM? Employee { get; set; }
	}
}