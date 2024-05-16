using System;
using System.Text;

namespace SystemManagement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Dùng bảng mã UTF8 nếu các nội dung có dấu*/
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Hello world");
        }
    }
}