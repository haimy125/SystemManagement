using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SystemManagement.Models;

namespace SystemManagement.Services
{
    public class DepartmentService
    {
        private readonly List<DepartmentModel> _departments = new List<DepartmentModel>();

        // Hàm thêm phòng ban
        public void AddDepartment(DepartmentModel department)
        {
            _departments.Add(department);
        }

        // Hàm cập nhật phòng ban
        public bool UpdateDepartment(int departmentId, string newName)
        {
            var department = _departments.FirstOrDefault(d => d.DepartmentId == departmentId);
            if (department != null)
            {
                department.UpdateDepartment(newName);
                return true;
            }

            return false;
        }

        // Hàm xóa phòng ban
        public bool DeleteDepartment(int departmentId)
        {
            if (departmentId != 0)
            {
                var department = _departments.FirstOrDefault(d => d.DepartmentId == departmentId);
                if (department != null)
                {
                    _departments.Remove(department);
                    return true;
                }
            }
            return false;
        }
        
        // Hàm tìm kiếm phòng ban theo mã
        public DepartmentModel BinarySearchById(int key)
        {
            int left = 0;
            int right = _departments.Count - 1;
            int mid;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (_departments[mid].DepartmentId == key)
                {
                    return _departments[mid];
                }
                else if (_departments[mid].DepartmentId > key)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return null;
        }
        
        // Hàm tìm kiếm phòng ban theo tên
        public DepartmentModel OrderLinearSearchByName(string name)
        {
            foreach (var department in _departments)
            {
                if (department.DepartmentName.Equals(name))
                {
                    return department;
                }
            }

            return null;
        }

        // Hàm lấy danh sách tất cả phòng ban
        public List<DepartmentModel> GetAllDepartments()
        {
            return _departments;
        }

        // Hàm thêm nhân viên vào phòng ban
        public bool AddEmployeeToDepartment(int departmentId, EmployeeModel employee)
        {
            var department = _departments.FirstOrDefault(d => d.DepartmentId == departmentId);
            if (department != null)
            {
                department.AddEmployee(employee);
                return true;
            }

            return false;
        }

        // Hàm sửa thông tin nhân viên
        public bool UpdateEmployeeInDepartment(int departmentId, EmployeeModel updatedEmployee)
        {
            var department = _departments.FirstOrDefault(d => d.DepartmentId == departmentId);
            if (department != null) return department.UpdateEmployee(updatedEmployee);
            return false;
        }

        // Hàm xóa nhân viên khỏi phòng ban
        public bool DeleteEmployeeFromDepartment(int departmentId, int employeeId)
        {
            var department = _departments.FirstOrDefault(d => d.DepartmentId == departmentId);
            if (department != null) return department.DeleteEmployee(employeeId);
            return false;
        }
        
        public void WriteDepartmentsToFile(List<DepartmentModel> departments)
        {
            // Đường dẫn của tệp văn bản
            string filePath = "Departments.txt";
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), filePath);
            
            // Ghi dữ liệu từ Dictionary vào tệp văn bản
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var department in departments)
                {
                    writer.WriteLine(department.DepartmentId + "," + department.DepartmentName);
                }
            }
            Console.WriteLine("Dữ liệu đã được ghi vào file " + path);
        }
        
        public void ReadDepartmentToFile()
        {
            // Đường dẫn của tệp văn bản
            string fileName = "Departments.txt";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
            
            // Xóa danh sách trước khi đọc dữ liệu mới
            _departments.Clear();
            
            // Kiểm tra xem tệp tồn tại
            if (File.Exists(filePath))
            {
                // Đọc dữ liệu từ tệp văn bản
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Phân tách dòng thành key và value, sử dụng dấu phẩy làm delimiter
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            int id;
                            if (int.TryParse(parts[0], out id))
                            {
                                // Tạo đối tượng DepartmentModel và thêm vào danh sách departments
                                DepartmentModel departmentModel = new DepartmentModel
                                {
                                    DepartmentId = id,
                                    DepartmentName = parts[1]
                                };
                                _departments.Add(departmentModel);
                            }
                        }
                    }
                }

                // In ra dữ liệu đã đọc từ tệp văn bản
                Console.WriteLine("Dữ liệu đã đọc từ file " + filePath + ":");
                List<DepartmentModel> departmentModels = GetAllDepartments();
                Console.WriteLine("\n----------PHÒNG BAN-----------");
                Console.WriteLine("{0, -20} {1, -35}", "Mã phòng ban", "Tên phòng ban");
                foreach (DepartmentModel department in departmentModels)
                {
                    Console.WriteLine("{0, -20} {1, -35}", department.DepartmentId, department.DepartmentName);
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy file " + filePath);
            }
        }
    }
}