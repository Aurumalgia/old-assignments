using System;
using System.Collections.Generic;
using System.Text;

namespace BoatRentals
{
    static class Pricing
    {
        public enum rates
        {
            basePrice,
            extraHourPrice,
            extraPowerLevelRate,
            extraGuestRate,
            upstreamPrice,
            downstreamPrice,
            taxRate
        }

        public enum maxBeforeUpcharge
        {
            maxHours = 18,
            maxLevel = 1,
            maxGuests = 3
        }

        public static double getRate(rates rate)
        {
            switch (rate)
            {
                case rates.basePrice:
                    return 179.99;

                case rates.extraHourPrice:
                    return 11.5;

                case rates.extraPowerLevelRate:
                    return .085;

                case rates.extraGuestRate:
                    return .08;

                case rates.upstreamPrice:
                    return 47;

                case rates.downstreamPrice:
                    return -30;

                case rates.taxRate:
                    return .0605;

                default:
                    return 0;
            }
        }
    }
}
