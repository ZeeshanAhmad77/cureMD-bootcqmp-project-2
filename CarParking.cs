using System;
using System.Collections.Generic;
using System.Text;

namespace CarParkingCalculator
{
    public class CarParking
    {
       
        private string vehicleType;
        private Double hourParked;
        private int maxHourParked=24;
        private Double feeUpToTHree;
        private Double feeGreaterThanThree;
        private Double maxFee;
        private Double totalFee;




        public void showParkingFee()
        {
            Console.WriteLine("------Car Parking Fee------");
            Console.WriteLine($"The Type of the Vehicle is : {vehicleType}");
            Console.WriteLine($"The Number of Hours parked : {hourParked}");
            Console.WriteLine($"The Total amount of parking Fees is : {totalFee} $");
        }
     

        public virtual Double CalculateParkingFees(double hParked)
        {
            if (hParked <= 3)
            {
                totalFee = feeUpToTHree;
                return totalFee;

            }
            else if(hParked>3 && hParked <24)
            {
                totalFee = feeUpToTHree + (hParked - 3) * feeGreaterThanThree;
                return totalFee;
            }
            if (hParked==24)
            {
                totalFee = maxFee;
                return totalFee;
            }
            return 0.0;


        }
        //totalFee
        public Double getTotalFee()
        {
            return totalFee;
        }
        public void setTotalFee(Double tfee)
        {
            totalFee = tfee;
        }

        //MaxFee
        public Double getMaxFee()
        {
            return maxFee;
        }
        public void setMaxFee(Double mfee)
        {
            maxFee = mfee;
        }

        //feeGreaterThanThree
        public Double getFeeGreaterThanThree()
        {
            return feeGreaterThanThree;
        }
        public void setFeeGreaterThanThree(Double gthree)
        {
            feeGreaterThanThree =gthree;
        }

        // feeUpToTHree
        public Double getFeeUpToTHree()
        {
            return feeUpToTHree;
        }
        public void setFeeUpToTHree(Double fthree)
        {
            feeUpToTHree = fthree;
        }

        //vehicleType
            public string getVehicleType()
        {
            return vehicleType;
        }
        public void setVehicleType(string veh)
        {
            vehicleType = veh;
        }

        //hourParked
        public Double getHourParked()
        {
            return hourParked;
        }
        public void setHourParked(Double hpar)
        {
            hourParked = hpar;
        }
        //maxHourParked
        public Double getMaxHourParked()
        {
            return maxHourParked;
        }

    }
}
