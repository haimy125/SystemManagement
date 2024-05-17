using System;
using System.Text.RegularExpressions;

namespace SystemManagement.utils
{
    public class DateOfBirth
    {
        private static readonly Regex regex = new Regex(@"^\d{2}-\d{2}-\d{4}$");

        public bool checkDateOfBirth(DateTime dateOfBirth)
        {
            // Chuyển đổi DateTime thành chuỗi theo định dạng dd-MM-yyyy
            var dateOfBirthString = dateOfBirth.ToString("dd-MM-yyyy");

            if (dateOfBirthString != null)
                if (regex.IsMatch(dateOfBirthString))
                    return true;
            return false;
        }
    }
}