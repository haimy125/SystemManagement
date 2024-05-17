using System;
using System.Collections.Generic;
using SystemManagement.Models;

namespace SystemManagement.utils
{
    public class ConvertEnumFormat
    {
        public Dictionary<Gender, string> GenderDescriptions = new Dictionary<Gender, string>
        {
            { Gender.Male, "Nam" },
            { Gender.Female, "Nữ" },
            { Gender.Other, "Khác" }
        };

        public Dictionary<Position, string> PositionDescriptions = new Dictionary<Position, string>
        {
            { Position.Teacher, "Giảng Viên" },
            { Position.Staff, "Nhân viên" }
        };

        public string GetGenderDescription(Gender gender)
        {
            return GenderDescriptions[gender];
        }

        public string GetPositionDescription(Position position)
        {
            return PositionDescriptions[position];
        }

        public Gender InputGender()
        {
            while (true)
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        return Gender.Male;
                    case "2":
                        return Gender.Female;
                    case "3":
                        return Gender.Other;
                    default:
                        Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập lại.");
                        break;
                }
            }
        }

        public Position InputPosition()
        {
            while (true)
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        return Position.Teacher;
                    case "2":
                        return Position.Staff;
                    default:
                        Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập lại.");
                        break;
                }
            }
        }
    }
}