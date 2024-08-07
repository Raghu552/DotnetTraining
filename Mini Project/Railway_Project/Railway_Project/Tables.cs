using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Project
{
    class Tables
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int Tno { get; set; }
        public int Number_of_seats { get; set; }
        public DateTime BookingDate { get; set; }
    }
    public class Train
    {
        public int Tno { get; set; }
        public string Tname { get; set; }
        public string From { get; set; }
        public string Dest { get; set; }
        public decimal Price { get; set; }
        public string Class_of_travel { get; set; }
        public string Train_status { get; set; }
        public int Seats_available { get; set; }
    }
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
