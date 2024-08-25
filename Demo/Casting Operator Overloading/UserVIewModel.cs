using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Casting_Operator_Overloading
{
    // view model : Class representing the data that will be rendered on the view
    internal class UserVIewModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }


        public static explicit operator UserVIewModel(User user)
        {
            string[]? Names = user?.FullName?.Split(' ');
            return new UserVIewModel()
            {
                FirstName = Names?.Length > 0 ? Names[0] : string.Empty,
                LastName = Names?.Length > 1 ? Names[1] : string.Empty,
                Email = user?.Email
            };
        }
    }
}
