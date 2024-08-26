using Assignment.Project01;
using Assignment.Project02;


namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            _3DPoint[] points =
            {
                new _3DPoint(),
                new _3DPoint()
            };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter Cordinates of Point number {i + 1}: ");
                Console.Write("Enter X:");
                points[i].X = int.Parse(Console.ReadLine());

                Console.Write("Enter Y:");
                points[i].Y = Convert.ToInt32(Console.ReadLine());

                int z;

                do
                {
                    Console.Write("Enter Z:");
                } while (!int.TryParse(Console.ReadLine(), out z));
                points[i].Z = z;
            }



            //_3DPoint P1 = new _3DPoint();
            //_3DPoint P2 = new _3DPoint();

            //P1.ReadPoint();

            //P2.ReadPoint();

            //if(P1 == P2)
            //{
            //    Console.WriteLine("EQUALS");
            //}
            //else
            //{
            //    Console.WriteLine("!EQUALS");
            //}

            //_3DPoint[] points =
            //{
            //    new _3DPoint(),
            //    new _3DPoint(),
            //    new _3DPoint(),
            //    new _3DPoint(),
            //    new _3DPoint(),
            //    new _3DPoint(),
            //    new _3DPoint(),
            //    new _3DPoint(),
            //    new _3DPoint()
            //};

            //for(int i=0;i<points.Length;i++)
            //{
            //    points[i].ReadPoint();
            //}

            //Array.Sort(points);

            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine(points[i]);
            //} 
            #endregion

            #region Q2

            //Maths m = new Maths();

            //Console.WriteLine(m.Add(1,2));
            //Console.WriteLine(m.Subtract(3,1));
            //Console.WriteLine(m.Multiply(2,3));
            //Console.WriteLine(m.Divide(2,1));

            //Console.WriteLine(Maths.Add(1, 2));
            //Console.WriteLine(Maths.Subtract(3, 1));
            //Console.WriteLine(Maths.Multiply(2, 3));
            //Console.WriteLine(Maths.Divide(2, 1));

            #endregion


        }
    }
}