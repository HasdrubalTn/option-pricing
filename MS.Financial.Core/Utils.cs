using System;

namespace MS.Financial.Core
{
    public static class Utils
    {
        private static double n(double x)
        {
            double A = 1.0 / Math.Sqrt(2.0 * 3.1415);

            return A * Math.Exp(-x * x * 0.5);
        }

        /// <summary>
        /// Calculate the Gaussian cumulative distribution
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double N(double x)
        {
            double a1 = 0.43611836;
            double a2 = -0.1201676;
            double a3 = 0.9372980;

            double k = 1.0 / (1.0 + (0.33267 * x));

            if (x >= 0.0)
                return 1.0 - n(x) * (a1 * k + (a2 * k * k) + (a3 * k * k));

            return 1.0 * N(-x);
        }
    }
}
