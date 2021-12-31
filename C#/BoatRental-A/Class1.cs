//Class for Form1
using System;

namespace BoatRental
{
    class Class1
    {
        //Instance variables
        private int passenger, engineNumb;//variables for constructor
        private string departTown, arrivalTown;//variables for constructor
        //variables for charges 
        private double basePrice = 179.99, extraHour = 11.50, engineLevel = 8.5, extraPerson = 8.0,
            upstreamCharge = 47.00, downstreamCharge = -30.00, taxCharge = 6.05;
        //variable string for towns
        private string town1 = "Arco", town2 = "Buttek", town3 = "Camdel", town4 = "Dertoth", town5 = "Esmoll";

    //constructor
    public Class1(int passenger, int engineNumb, string departTown, string arrivalTown, double grandTotal, int hours)
        {
            this.passenger = passenger;
            this.engineNumb = engineNumb;
            this.departTown = departTown;
            this.arrivalTown = arrivalTown;
        }

        public int Passenger
        {
            get
            {
                return passenger;
            }
        }

        public int EngineNumb
        {
            get
            {
                return engineNumb;
            }
        }
        public string DepartTown
        {   
            get
            {
                return departTown;
            }
        }
        public string ArrivalTown
        {
            get
            {
                return arrivalTown;
            }
        }
        //Calculate taxes
        public double taxesTotal(double grandTotal)
        {
            double quoteTotal = grandTotal * (taxCharge / 100);
            quoteTotal = Math.Round((double)quoteTotal, 2);
            return quoteTotal;
        }
        //calculate charges per extra person
        public double PeopleCharge(int passanger)
        {
            double total = ((extraPerson / 100) * basePrice);
            passanger -= 3;
            total = total * passanger;
            total = Math.Round((double)total, 2);
            return total;
        }
        //calculate engine levels
        public double LevelCharge(int engineNumb)
        {
            double levelTotal = ((engineLevel / 100) * basePrice);
            engineNumb -= 1;
            levelTotal = engineNumb * levelTotal;
            levelTotal = Math.Round((double)levelTotal, 2);
            return levelTotal;
        }
        //calculate extra hours charges
        public double hoursCharge(int hours)
        {
            hours -= 18;
            double totalCharge = hours * extraHour;
            return totalCharge;
        }
        //calculate stream docks charges
        public double TownCost(string departTown, string arrivalTown)
        {
            double townTotal = 0.0;
            
            //if Departure dock is Arco
            if (departTown == town1)
            {
                //if arrival dock is Buttek
                if (arrivalTown == town2)
                {
                    townTotal = downstreamCharge;
                }
                
                //if arrival dock is Camdel
                else if (arrivalTown == town3)
                {
                    townTotal = downstreamCharge * 2;
                }
                
                //if arrival dock is Dertoth
                else if (arrivalTown == town4)
                {
                    townTotal = downstreamCharge * 3;
                }
                
                //if arrival dock is Esmoll
                else if (arrivalTown == town5)
                {
                    townTotal = downstreamCharge * 4;
                }
            }
            
            //if Departure dock is Buttek
            else if (departTown == town2) 
            {
                //if arrival dock is Arco
                if (arrivalTown == town1)
                {
                    townTotal = upstreamCharge;
                }
                
                //if arrival dock is Camdel
                else if (arrivalTown == town3)
                {
                    townTotal = downstreamCharge;
                }
                
                //if arrival dock is Dertoth
                else if (arrivalTown == town4)
                {
                    townTotal = downstreamCharge * 2;
                }
                
                //if arrival dock is Esmoll
                else if (arrivalTown == town5)
                {
                    townTotal = downstreamCharge * 3;
                }
            }
            
            //if Departure dock is Camdel
            else if (departTown == town3)
            {
                //if arrival dock is Arco
                if (arrivalTown == town1)
                {
                    townTotal = upstreamCharge * 2;
                }
                
                //if arrival dock is Buttek
                else if (arrivalTown == town2)
                {
                    townTotal = upstreamCharge;
                }
                
                //if arrival dock is Dertoth
                else if (arrivalTown == town4)
                {
                    townTotal = downstreamCharge;
                }
                
                //if arrival dock is Esmoll
                else if (arrivalTown == town5)
                {
                    townTotal = downstreamCharge * 2;
                }
            }
            
            //if Departure dock is Dertoth
            else if (departTown == town4)
            {
                //if arrival dock is Arco
                if (arrivalTown == town1)
                {
                    townTotal = upstreamCharge * 3;
                }
                
                //if arrival dock is Buttek
                else if (arrivalTown == town2)
                {
                    townTotal = upstreamCharge * 2;
                }
                
                //if arrival dock is Camdel
                else if (arrivalTown == town3)
                {
                    townTotal = upstreamCharge;
                }
                
                //if arrival dock is Esmoll
                else if (arrivalTown == town5)
                {
                    townTotal = downstreamCharge;
                }
            }
            
            //if Departure dock is Esmoll
            else if (departTown == town5)
            {
                //if arrival dock is Arco
                if (arrivalTown == town1)
                {
                    townTotal = upstreamCharge * 4;
                }
                
                //if arrival dock is Buttek
                else if (arrivalTown == town2)
                {
                    townTotal = upstreamCharge * 3;
                }
                
                //if arrival dock is Camdel
                else if (arrivalTown == town3)
                {
                    townTotal = upstreamCharge * 2;
                }
                
                //if arrival dock is Dertoth
                else if (arrivalTown == town4)
                {
                    townTotal = upstreamCharge;
                }
            }

            return townTotal;
        }
    }
}