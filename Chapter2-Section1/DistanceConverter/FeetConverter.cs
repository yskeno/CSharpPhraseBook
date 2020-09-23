using System;

namespace DistanceConverter
{
    public static class FeetConverter
    {
        private const double ratio = 0.3048;


        public static double FromMeter(double meter)
        {
            return meter / ratio;
        }

        public static double ToMeter(double feet)
        {
            return feet * ratio;
        }

        public static double FromInchToMeter(double inch)
        {
            return inch * 0.0254;
        }
    }
}