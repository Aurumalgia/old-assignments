using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static BoatRentals.Pricing;

namespace BoatRentals
{
    class Quote
    {
        
        
        private List<double> bill = new List<double>();
        private double grandTotal = 0;
        public Quote ( int upstreamSegments, int numOfHours, int enginePower, int guestCount)
        {
            basePrice();
            extraHourRate(numOfHours);
            engineLevelRate(enginePower);
            extraPersonRate(guestCount);
            upOrDownstream(upstreamSegments);
            Tax();

            grandTotal = Math.Round(grandTotal, 2);
        }

        public double getTotal()
        {
            return bill.Last();
        }

        public String getBill()
        {
            String billList = "";
            double prevItem = 0;
            foreach (double item in bill)
                billList += "$" + item + "\n\n";

            billList += "$" + grandTotal;
            return billList;
        }

        private void basePrice()
        {
            bill.Add(getRate(rates.basePrice));
            grandTotal += bill.Last();
        }

        private void extraHourRate(int numOfHours)
        {
            if (numOfHours > (int)maxBeforeUpcharge.maxHours)
                bill.Add((numOfHours - (int)maxBeforeUpcharge.maxHours) * getRate(rates.extraHourPrice));

            else
                bill.Add(0);
            grandTotal += bill.Last();
        }

        private void engineLevelRate(int enginePower)
        {
            double engineIncrease = 0;
            for (enginePower = enginePower; enginePower > 1; --enginePower)
            {
                engineIncrease += grandTotal * (getRate(rates.extraPowerLevelRate));
                grandTotal += engineIncrease;
            }
            bill.Add(Math.Round(engineIncrease, 2));
        }

        private void extraPersonRate(int guestCount)
        {
            double extraPersonPrice = 0;
            for (guestCount = guestCount; guestCount > 3; --guestCount)
            {
                extraPersonPrice += grandTotal * (getRate(rates.extraGuestRate));
                grandTotal += extraPersonPrice;
            }
            bill.Add(Math.Round(extraPersonPrice, 2));
        }

        private void upOrDownstream(int upstreamSegmants)
        {
            double upstreamPrice = 0;
            if (upstreamSegmants >= 0)
            {
                for (upstreamSegmants = upstreamSegmants; upstreamSegmants > 0; --upstreamSegmants)
                {
                    upstreamPrice += getRate(rates.upstreamPrice);
                }
            }
            else
            {
                for (upstreamSegmants = upstreamSegmants; upstreamSegmants < 0; ++upstreamSegmants)
                {
                    upstreamPrice += getRate(rates.downstreamPrice);
                }
            }
            bill.Add(Math.Round(upstreamPrice, 2));
            grandTotal += bill.Last();

        }

        private void Tax()
        {
            bill.Add(Math.Round(grandTotal * (getRate(rates.taxRate)), 2));
            grandTotal += bill.Last();
        }

        
    }
}
