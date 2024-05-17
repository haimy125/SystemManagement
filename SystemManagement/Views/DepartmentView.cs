using System;
using SystemManagement.Controllers;
using SystemManagement.Services;

namespace SystemManagement.Views
{
    public class DepartmentView
    {
        private DepartmentService _departmentService = new DepartmentService();
        private DepartmentController _controller = new DepartmentController();
        
        public void DepartmentManagement()
        {
            while (true)
            {
                Console.WriteLine("---------QUẢN LÝ PHÒNG BAN---------");
                Console.WriteLine("1. Thêm một phòng ban");
                Console.WriteLine("2. Xem danh sách phòng ban");
                Console.WriteLine("3. Cập nhật thông tin phòng ban");
                Console.WriteLine("4. Tìm phòng theo mã phòng");
                Console.WriteLine("5. Tìm phòng theo tên");
                Console.WriteLine("6. Xóa phòng ban");
                Console.WriteLine("7. Ghi danh sách phòng ban ra txt");
                Console.WriteLine("8. Đọc danh sách phòng ban từ txt");
                Console.WriteLine("9. Quản lý nhân sự");
                Console.WriteLine("10. Quay lại menu chính");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("--------------------------------------------");
                Console.Write("Xin mời lựa chọn chức năng: ");

                var cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "1":
                        _controller.CreateDepartment(_departmentService);
                        break;
                    case "2":
                        _controller.ViewAllDepartments(_departmentService);
                        break;
                    case "3":
                        Console.WriteLine("Danh sách phòng ban trước cập nhật");
                        _controller.ViewAllDepartments(_departmentService);
                        _controller.UpdateDepartment(_departmentService);
                        Console.WriteLine("Danh sách phòng ban sau cập nhật");
                        _controller.ViewAllDepartments(_departmentService);
                        break;
                    case "4":                        
                        _controller.BinarySearchById(_departmentService);
                        break;
                    case "5":
                        _controller.OrderLinearSearchByName(_departmentService);
                        break;
                    case "6":
                        _controller.DeleteDepartment(_departmentService);
                        break;
                    case "7":
                        _controller.WriteDepartmentsToFile(_departmentService);
                        break;
                    case "8":
                        _controller.ReadDepartmentToFile(_departmentService);
                        break;
                    case "9":
                        break;
                    case "10":
                        return;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Không hợp lệ!");
                        break;
                }
            }
        }
        
        public void EmployeeManagement()
        {
            while (true)
            {
                Console.WriteLine("---------QUẢN LÝ NHÂN SỰ---------");
                Console.WriteLine("1. Thêm nhân sự");
                Console.WriteLine("2. Cập nhật thông tin nhân sự");
                Console.WriteLine("3. Tìm kiếm nhân sự theo mã số");
                Console.WriteLine("4. Xóa nhân sự");
                Console.WriteLine("5. Hiển thị danh sách nhân sự");
                Console.WriteLine("6. Thêm nhân sự vào phòng ban");
                Console.WriteLine("7. Điều chuyển nhân sự giữa phòng ban");
                Console.WriteLine("8. Ghi danh sách nhân sự ra txt");
                Console.WriteLine("9. Đọc danh sách nhân sự từ txt");
                Console.WriteLine("10. Quay lại menu chính");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("--------------------------------------------");
                Console.Write("Xin mời lựa chọn chức năng: ");

                var cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    case "10":
                        return;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Không hợp lệ!");
                        break;
                }
            }
        }
    }
}