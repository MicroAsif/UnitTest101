using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest101.Lib.DemeritePointCalcultor
{
    public static class DemeritePoint
    {
        private const int SpeedLimit = 65;
        public static int CalculateDemeritePoints(int speed)
        {
            if (speed < 0)
                throw new ArgumentException("Negetive speed");
            if (speed <= SpeedLimit) return 0;
            const int kmPerDemeritePoint = 5;
            return (speed - SpeedLimit) / kmPerDemeritePoint;
        }
    }
}
