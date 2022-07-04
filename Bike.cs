using System;
using System.Collections.Generic;
using System.Text;

namespace CarParkingCalculator
{
    public class Bike : CarParking
    {


        public override Double CalculateParkingFees(double hParked)
        {

            this.setFeeUpToTHree(2.0);
            this.setFeeGreaterThanThree(0.5);
            this.setMaxFee(10.0);
            if (hParked <= 3)
            {

                this.setTotalFee(this.getFeeUpToTHree());
                return this.getTotalFee();
            }
             if (hParked > 3 && hParked < 24)
            {
                this.setTotalFee((this.getFeeUpToTHree() + (hParked - 3) * this.getFeeGreaterThanThree()));
                return this.getTotalFee();
            }
            if  (hParked == 24)
            {
                this.setTotalFee(this.getMaxFee());

                return this.getTotalFee();
            }
            Console.WriteLine("-----no Vehicle can parks for longer than 24 hours at a time-----");
            return 0.0;
        }


    }
}







