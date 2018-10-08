using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_Assignment02
{
    class TriangleSolver
    {
        public static string Analyze(int sideOne, int sideTwo, int sideThree)
        {
            string response;
            response = "Not a triangle";
            if (ValidateSides(sideOne, sideTwo, sideThree))
            {
                if ((sideOne == sideTwo) && (sideTwo == sideThree))
                {
                    response = "Equilateral";
                }
                if ((sideOne == sideTwo) || (sideOne == sideThree) || (sideTwo == sideThree))
                {
                    response = "Isosceles";
                }
                if ((sideOne != sideTwo) && (sideOne != sideThree) && (sideTwo != sideThree))
                {
                    response = "Scalene";
                }
            }
            else
            {
                response = "Not a triangle";
            }
            return response;
        }

        static Boolean ValidateSides(int sideOne, int sideTwo, int sideThree)
        {
            if (sideOne <= 0) return false;
            if (sideTwo <= 0) return false;
            if (sideThree <= 0) return false;
            return true;
        }

    }
}
