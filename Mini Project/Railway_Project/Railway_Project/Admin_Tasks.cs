using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Railway_Project
{
    public class Admin_Tasks
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        private static SqlConnection getConnection()
        {
            con = new SqlConnection("data source = ICS-LT-5S26573; initial catalog = railway;" +
                 "user id=sa; password=Infinite@552");
            con.Open();
            return con;
        }

        public User Admin_Login(string username, string password)
        {
            con = getConnection();
            cmd = new SqlCommand("select * from Users where Username = @Username and Password = @Password", con);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                return new User
                {
                    UserID = (int)dr["UserID"],
                    Name = dr["Name"].ToString(),
                    Username = dr["Username"].ToString(),
                    Password = dr["Password"].ToString()
                };
            }
            else
            {
                Console.WriteLine("Invalid credentials or user does not exist.");
                Console.Read();
                return null;
            }

        }

        public void AddTrain(Train train)
        {
            con = getConnection();
            cmd = new SqlCommand("insert into Trains values (@Tno, @Tname, @From, @Dest, @Price, @Class_of_travel, @Train_status, @Seats_available)", con);
            cmd.Parameters.AddWithValue("@Tno", train.Tno);
            cmd.Parameters.AddWithValue("@Tname", train.Tname);
            cmd.Parameters.AddWithValue("@From", train.From);
            cmd.Parameters.AddWithValue("@Dest", train.Dest);
            cmd.Parameters.AddWithValue("@Price", train.Price);
            cmd.Parameters.AddWithValue("@Class_of_travel", train.Class_of_travel);
            cmd.Parameters.AddWithValue("@Train_status", train.Train_status);
            cmd.Parameters.AddWithValue("@Seats_available", train.Seats_available);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Train added successfully.");
            Console.WriteLine("-------------------------------------");

        }

        public void Price_Update(int tno, decimal new_price)
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("update Trains set Price = @new_price where Tno = @Tno", con);
                cmd.Parameters.AddWithValue("@new_price", new_price);
                cmd.Parameters.AddWithValue("@Tno", tno);
                int row_effected = cmd.ExecuteNonQuery();
                if (row_effected == 0)
                {
                    throw new Exception($"Train {tno} not found in database");
                }
                Console.WriteLine("Price updated successfully.");
                Console.WriteLine("-------------------------------------");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Train_Status(int tno, string status)
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("update Trains set Train_status = @Train_status where Tno = @Tno", con);
                cmd.Parameters.AddWithValue("@Train_status", status);
                cmd.Parameters.AddWithValue("@Tno", tno);
                int rows=cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    throw new Exception($"Train {tno} not found in database");
                }
                Console.WriteLine("Train status updated successfully.");
                Console.WriteLine("-------------------------------------");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void View_Bookings()
        {
            con = getConnection();
            cmd = new SqlCommand("select * from Bookings", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"Booking ID: {dr["BookingID"]}, User ID: {dr["UserID"]}, Train No: {dr["Tno"]}, Seats: {dr["Number_of_seats"]}, Date: {dr["BookingDate"]}");
            }
            Console.WriteLine("-------------------------------------");

        }

        public void View_Cancellations()
        {
            con = getConnection();
            cmd = new SqlCommand("select * from Cancellations", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"Cancellation ID: {dr["CancellationID"]}, Booking ID: {dr["BookingID"]}, Seats Canceled: {dr["Number_of_seats"]}, Date: {dr["CancellationDate"]}");
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}
