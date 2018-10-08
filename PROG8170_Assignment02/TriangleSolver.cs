using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_Assignment02
{
    public static class TriangleSolver
    {
        public static string Analyze(int sideOne, int sideTwo, int sideThree)
        {
            if (ValidateSides(sideOne, sideTwo, sideThree))
            {
                if ((sideOne == sideTwo) && (sideTwo == sideThree))
                {
                    return "Equilateral";
                }
                if ((sideOne == sideTwo) || (sideOne == sideThree) || (sideTwo == sideThree))
                {
                    return "Isosceles";
                }
                if ((sideOne != sideTwo) && (sideOne != sideThree) && (sideTwo != sideThree))
                {
                    return "Scalene";
                }
            }
            else
            {
                return "Not a triangle";
            }
            return "Not a triangle";
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
