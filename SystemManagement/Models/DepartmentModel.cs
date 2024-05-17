using System.Collections.Generic;
using System.Linq;

namespace SystemManagement.Models
{
    public class DepartmentModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public List<EmployeeModel> listOfEmployees { get; set; } = new List<EmployeeModel>();

        // Hàm thêm nhân viên vào danh sách nhân viên của phòng ban
        public void AddEmployee(EmployeeModel employee)
        {
            if (employee != null)
            {
                listOfEmployees.Add(employee);
                employee.Department = this;
            }
        }

        // Hàm sửa thông tin nhân viên
        public bool UpdateEmployee(EmployeeModel updatedEmployee)
        {
            var employee = listOfEmployees.FirstOrDefault(e => e.EmployeeId == updatedEmployee.EmployeeId);
            if (employee != null)
            {
                employee.FullName = updatedEmployee.FullName;
                employee.DateOfBirth = updatedEmployee.DateOfBirth;
                employee.Gender = updatedEmployee.Gender;
                employee.Position = updatedEmployee.Position;
                // No need to update department as it's implied to be within the same department
                return true;
            }

            return false;
        }

        // Hàm xóa nhân viên khỏi danh sách nhân viên của phòng ban
        public bool DeleteEmployee(int employeeId)
        {
            var employee = listOfEmployees.FirstOrDefault(e => e.EmployeeId == employeeId);
            if (employee != null)
            {
                listOfEmployees.Remove(employee);
                return true;
            }

            return false;
        }

        // Hàm sửa thông tin phòng ban
        public void UpdateDepartment(string newName)
        {
            DepartmentName = newName;
        }
    }
}