
using Demo.Casting_Operator_Overloading;
using Demo.OperatorsOverloading;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operator Overloading 
            //Complex c1 = new Complex() { Real = 10, Imag = 6 };
            //Console.WriteLine(c1);

            //Complex c2 = new Complex() { Real = 5, Imag = 3 };
            //Console.WriteLine(c2);

            //Complex c3 = default; // Null 

            #region Binary Operators
            //c3 = c1 + c2; 

            //Console.WriteLine(c3);

            //c3 = c1 - c2;

            //c3 += c1;
            //c3 -= c2; 
            #endregion

            #region Unary Operators
            //c3 = ++c1; //prefix
            //c3 = c1++; //postfix

            //c3 = --c1; //prefix
            //c3 = c1--; //postfix 
            #endregion

            #region Relational Operators < > >= <= = !=
            //if (c1 > c2)
            //    Console.WriteLine("C1 > C2");
            //else if (c2 > c1)
            //    Console.WriteLine("c2 > c1");

            //if (c1 == c2)
            //    Console.WriteLine("C1 > C2");
            //else if (c2 != c1)
            //    Console.WriteLine("c2 > c1");

            #endregion

            //Console.WriteLine(c3);

            #endregion

            #region Casting Operators Overloading 

            //object obj = 3;

            //int X = (int) obj; // Needs Explicit Casting  (Recommended)
            // (int) casting operator

            //Complex c1 = new Complex() { Real = 10, Imag = 6 };
            //int Y = (int) c1; 
            //// invalid naturally, Needs Implicit Casting unless you teach it a new behaviour

            //string s1 = c1; // valid cause we changed the behaviour of casting operator
            //// explicit casting is recommended 

            //Console.WriteLine(Y);
            //Console.WriteLine(s1);
            //Console.WriteLine(c1);
            #endregion

            #region Casting Operator Overloading - Mapping

            // Model : Class Reperesnt table exisitng in the database
            // ViewModel : Class Reperesnt the data that will be rendered at view

            // Database -> Model {User} => ViewModel {UserViewModel} -> View
            // View -> ViewModel {UserViewModel} => Model {User} -> Database

            User user = new User()
            {
                Id = 10,
                FullName = "Aliaa Tarek",
                Email = "AliaaTarek42@gamil.com",
                Password = "Password",
                SecurityStamp = Guid.NewGuid()
            };
            
            //Console.WriteLine(user.SecurityStamp);

            UserVIewModel userViewModel = (UserVIewModel) user; // Explicit casting
            // mappping

            Console.WriteLine(userViewModel.FirstName);
            Console.WriteLine(userViewModel.LastName);
            Console.WriteLine(userViewModel.Email);

            object obj = new UserVIewModel();
            userViewModel = (UserVIewModel)(obj);
            #endregion
        }
    }
}
