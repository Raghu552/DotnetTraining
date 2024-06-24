using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Doctor
    {
        private int regnNo;
        private string name;
        private int feesCharged;
        public Doctor(int regnNo, string name, int feesCharged)
        {
            this.regnNo = regnNo;
            this.name = name;
            this.feesCharged = feesCharged;
        }
        public int RegnNo
        {
            get { return regnNo; }
            set { regnNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int FeesCharged
        {
            get { return feesCharged; }
            set { feesCharged = value; }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Doctor Details:");
            Console.WriteLine($"Registration Number: {RegnNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Fees Charged: ${FeesCharged}");
        }
    }
}
