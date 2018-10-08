using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_Assignment02
{
    class Program
    {
        static bool keepRunning = true;
        static void Main(string[] args)
        {
            try
            {
                Program prog = new Program();
                do
                {
                    int option = prog.GetMenuOptionFromUser();

                    switch (option)
                    {
                        case 1:
                            int sideOne = prog.GetSideOneFromUser();
                            int sideTwo = prog.GetSideTwoFromUser();
                            int sideThree = prog.GetSideThreeFromUser();
                            string response = TriangleSolver.Analyze(sideOne, sideTwo, sideThree);
                            Console.WriteLine("TriangleSolver Analyze : " + response);

                            break;
                        case 2:
                            keepRunning = false;
                            break;

                        default:
                            break;
                    }
                }
                while (keepRunning);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                Console.ReadKey();
            }
        }
        private int GetMenuOptionFromUser()
        {
            string response = string.Empty;
            bool valid = false;
            int output = 0;
            do
            {
                if (valid) { Console.WriteLine("Please select a valid option"); }
                valid = true;
                Console.WriteLine();
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                Console.WriteLine();
                response = Console.ReadLine();
            } while (!int.TryParse(response, out output) || output <= 0 || output > 2);

            return output;
        }

        private int GetSideOneFromUser()
        {
            string response = string.Empty;
            bool valid = false;
            int output = 0;
            do
            {
                if (valid) { Console.WriteLine("Please select a valid input ( Greater then 0 )"); Console.WriteLine(); }
                valid = true;

                Console.Write("Please enter first side of triangle : ");
                response = Console.ReadLine();
            } while (!int.TryParse(response, out output) || output <= 0);
            return output;
        }
        private int GetSideTwoFromUser()
        {
            string response = string.Empty;
            bool valid = false;
            int output = 0;
            do
            {
                if (valid) { Console.WriteLine("Please select a valid input ( Greater then 0 )"); Console.WriteLine(); }
                valid = true;

                Console.Write("Please enter secound side of triangle : ");
                response = Console.ReadLine();
            } while (!int.TryParse(response, out output) || output <= 0);
            return output;
        }
        private int GetSideThreeFromUser()
        {
            string response = string.Empty;
            bool valid = false;
            int output = 0;
            do
            {
                if (valid) { Console.WriteLine("Please select a valid input ( Greater then 0 )"); Console.WriteLine(); }
                valid = true;

                Console.Write("Please enter third side of triangle : ");
                response = Console.ReadLine();
            } while (!int.TryParse(response, out output) || output <= 0);
            return output;
        }
    }
}
