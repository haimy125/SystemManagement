using System;
using System.Text;
using SystemManagement.Views;

namespace SystemManagement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Dùng bảng mã UTF8 nếu các nội dung có dấu*/
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            DepartmentView departmentView = new DepartmentView();
            while (true)
            {
                Console.WriteLine("---------CHƯƠNG TRÌNH QUẢN LÝ HỆ THỐNG---------");
                Console.WriteLine("1. QUẢN LÝ PHÒNG BAN");
                Console.WriteLine("2. QUẢN LÝ NHÂN SỰ");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("--------------------------------------------");
                Console.Write("Xin mời lựa chọn chức năng: ");

                var cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "1":
                        departmentView.DepartmentManagement();
                        break;
                    case "2":
                        departmentView.EmployeeManagement();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Không hợp lệ, vui lòng nhập lại!");
                        break;
                }
            }
        }
    }
}