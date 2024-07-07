using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public static class ConcessionLibrary
    {
         const double Fare = 500;
        public static string Concession1(int age)
        {
            if (age <= 5 && age>=0)
            {
                return "Little Champs - Free Ticket";
            }
            else if (age > 60)
            {
                double concessionAmount = Fare * 0.3;
                double discountedFare = Fare - concessionAmount;
                return $"Senior Citizen - Fare after 30% concession: {discountedFare: r}";
            }
            else
            {
                return $"Ticket Booked - Fare: {Fare:r}";
            }
        }

    }
}
