using System;
using System.Collections.Generic;
using SystemManagement.Models;

namespace SystemManagement.utils
{
    public static class ConvertEnumFormat
    {
        public static string ToVietnameseGenderString(this Gender gender)
        {
            return gender switch
            {
                Gender.Male => "Nam",
                Gender.Female => "Nữ",
                Gender.Other => "Giới tính khác",
                _ => throw new ArgumentOutOfRangeException(nameof(gender), gender, null)
            };
        }
        public static Gender ToGender(this string genderString)
        {
            return genderString switch
            {
                "Nam" => Gender.Male,
                "Nữ" => Gender.Female,
                "Giới tính khác" => Gender.Other,
                _ => throw new ArgumentOutOfRangeException(nameof(genderString), genderString, null)
            };
        }
        public static string ToVietnamesePositionString(this  Position position)
        {
            return position switch
            {
                Position.Teacher => "Giảng Viên",
                Position.Manager => "Trưởng phòng",
                Position.Developer => "Lập trình viên",
                Position.Designer => "Nhà thiết kế",
                Position.Tester => "Kiểm thử viên",
                Position.HR => "Nhân sự",
                Position.Other => "Khác",
                _ => throw new ArgumentOutOfRangeException(nameof(position), position, null)
            };
        }
        
        public static Position ToPosition(this string positionString)
        {
            return positionString switch
            {
                "Giảng Viên" => Position.Teacher,
                "Trưởng phòng" => Position.Manager,
                "Lập trình viên" => Position.Developer,
                "Nhà thiết kế" => Position.Designer,
                "Kiểm thử viên" => Position.Tester,
                "Nhân sự" => Position.HR,
                "Khác" => Position.Other,
                _ => throw new ArgumentOutOfRangeException(nameof(positionString), positionString, null)
            };
        }

        // public static Dictionary<Gender, string> GenderDescriptions = new Dictionary<Gender, string>
        // {
        //     { Gender.Male, "Nam" },
        //     { Gender.Female, "Nữ" },
        //     { Gender.Other, "Khác" }
        // };
        //
        // public static Dictionary<Position, string> PositionDescriptions = new Dictionary<Position, string>
        // {
        //     { Position.Teacher, "Giảng Viên" },
        //     { Position.Manager, "Trưởng phòng" },
        //     { Position.Developer, "Lập trình viên" },
        //     { Position.Designer, "Nhà thiết kế" },
        //     { Position.Tester, "Kiểm thử viên" },
        //     { Position.HR, "Nhân sự" },
        //     { Position.Other, "Khác" }
        // };
        //
        // public static string GetGenderDescription(Gender gender)
        // {
        //     return GenderDescriptions[gender];
        // }
        //
        // public static string GetPositionDescription(Position position)
        // {
        //     return PositionDescriptions[position];
        // }

        public static Gender InputGender()
        {
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        return Gender.Male;
                    case 2:
                        return Gender.Female;
                    case 3:
                        return Gender.Other;
                    default:
                        Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập lại.");
                        break;
                }
            }
        }

        public static Position InputPosition()
        {
            while (true)
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        return Position.Teacher;
                    case "2":
                        return Position.Manager;
                    case "3":
                        return Position.Developer;
                    case "4":
                        return Position.Designer;
                    case "5":
                        return Position.Tester;
                    case "6":
                        return Position.HR;
                    case "7":
                        return Position.Other;
                    default:
                        Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập lại.");
                        break;
                }
            }
        }
    }
}