using System;
using System.Collections.Generic;
using System.Text;

namespace CarParkingCalculator
{
    public class Car : CarParking
    {



        public override Double CalculateParkingFees(double hParked)
        {

            this.setFeeUpToTHree(4.0);
            this.setFeeGreaterThanThree(1);
            this.setMaxFee(20.0);
           
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
            if (hParked == 24)
            {
                this.setTotalFee(this.getMaxFee());

                return this.getTotalFee();
            }
            Console.WriteLine("----no Vehicle can parks for longer than 24 hours at a time----");
            return 0.0;
        }




    }
}
