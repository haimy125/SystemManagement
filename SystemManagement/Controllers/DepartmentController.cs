using System;
using System.Collections.Generic;
using SystemManagement.Models;
using SystemManagement.Services;

namespace SystemManagement.Controllers
{
    public class DepartmentController
    {
        // Tạo phòng ban
        public void CreateDepartment(DepartmentService departmentService)
        {
            Console.Write("#Mã phòng ban: ");
            string id = Console.ReadLine();
            
            Console.Write("#Tên phòng ban: ");
            string name = Console.ReadLine();

            DepartmentModel departmentModel = new DepartmentModel
            {
                DepartmentId = Convert.ToInt32(id),
                DepartmentName = name
            };
            
            departmentService.AddDepartment(departmentModel);
            Console.WriteLine("Thêm phòng ban thành công.");
        }
        // Xem danh sách phòng ban
        public List<DepartmentModel> ViewAllDepartments(DepartmentService departmentService)
        {
            List<DepartmentModel> _list = departmentService.GetAllDepartments();
            
            if (_list == null || _list.Count == 0)
            {
                Console.WriteLine("Chưa có dữ liệu phòng ban, vui lòng bổ sung!");
                return _list;
            }
            
            Console.WriteLine("\n----------PHÒNG BAN-----------");
            Console.WriteLine("{0, -20} {1, -35}", "Mã phòng ban", "Tên phòng ban");
            foreach (DepartmentModel department in _list)
            {
                Console.WriteLine("{0, -20} {1, -35}", department.DepartmentId, department.DepartmentName);
            }
            
            Console.WriteLine();
            return _list;
        }

        public void UpdateDepartment(DepartmentService departmentService)
        {
            Console.Write("#Nhập vào mã phòng ban muốn cập nhật: ");
            int inputId = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("#Nhập vào tên phòng ban mới: ");
            string inputName = Console.ReadLine();

            if (departmentService.UpdateDepartment(inputId, inputName))
            {
                Console.WriteLine("#Bạn đã cập nhật phòng ban thành công!!!");
            }
            else
            {
                Console.WriteLine("#Cập nhật phòng ban thất bại!!!");
            }
        }
        public void BinarySearchById(DepartmentService departmentService)
        {
            Console.Write("#Nhập vào mã phòng ban muốn tìm: ");
            int inputId = Convert.ToInt32(Console.ReadLine());
            DepartmentModel department = departmentService.BinarySearchById(inputId);
            if (department != null)
            {
                Console.Write("#Tìm thấy phòng ban có mã là {0}: \n", inputId);
                Console.WriteLine("{0, -20} {1, -35}", "Mã phòng ban", "Tên phòng ban");
                Console.WriteLine("{0, -20} {1, -35}", department.DepartmentId, department.DepartmentName);
            }
            else
            {
                Console.Write("#Không tìm thấy phòng ban có mã là {0}: ", inputId);
            }
        }

        public void OrderLinearSearchByName(DepartmentService departmentService)
        {
            Console.Write("#Nhập vào tên phòng ban muốn tìm: ");
            string inputName = Console.ReadLine();
            DepartmentModel department = departmentService.OrderLinearSearchByName(inputName);
            if (department != null)
            {
                Console.Write("#Tìm thấy phòng ban có tên là {0}: \n", inputName);
                Console.WriteLine("{0, -20} {1, -35}", "Mã phòng ban", "Tên phòng ban");
                Console.WriteLine("{0, -20} {1, -35}", department.DepartmentId, department.DepartmentName);
            }
            else
            {
                Console.Write("#Không tìm thấy phòng ban có tên là {0}: ", inputName);
            }
        }
        
        // Hàm xóa phòng ban
        public void DeleteDepartment(DepartmentService departmentService)
        {
            Console.Write("#Nhập vào mã phòng ban muốn xóa: ");
            int inputId = Convert.ToInt32(Console.ReadLine());
            DepartmentModel department = departmentService.BinarySearchById(inputId);
            if (department != null)
            {
                if (departmentService.DeleteDepartment(inputId))
                {
                    Console.WriteLine("#Bạn đã xóa phòng ban thành công!!!");
                    Console.WriteLine("#Danh sách phòng ban hiện tại!!!");
                    ViewAllDepartments(departmentService);
                }
                else
                {
                    Console.WriteLine("#Xóa phòng ban thất bại!!!");
                }
            }
            else
            {
                Console.WriteLine("#Không tìm thấy phòng ban, mời nhập lại!!!");
            }
        }

        public void WriteDepartmentsToFile(DepartmentService departmentService)
        {
            List<DepartmentModel> _list = departmentService.GetAllDepartments();
            if (_list == null || _list.Count == 0)
            {
                Console.WriteLine("Chưa có dữ liệu phòng ban, vui lòng bổ sung!");
                return;
            }
            else
            {
                departmentService.WriteDepartmentsToFile(_list);
            }
        }
        
        public void ReadDepartmentToFile(DepartmentService departmentService)
        {
            departmentService.ReadDepartmentToFile();
        }
    }
}