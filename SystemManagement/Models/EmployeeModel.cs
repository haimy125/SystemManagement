using System;

namespace SystemManagement.Models
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public enum Position
    {
        Teacher,
        Manager,
        Developer,
        Designer,
        Tester,
        HR,
        Other
    }
    
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
        public Position Position { get; set; }
        public DepartmentModel Department { get; set; }
    }
}