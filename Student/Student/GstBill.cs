using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class GstBill
    {

        public void CalculateAndDisplayBill()
        {
            double roomCharge, foodCharge, otherCharges, totalBeforeGST, gstAmount, totalAfterGST;
            const double gstRate = 0.18; // GST rate is 18%

            Console.WriteLine("Welcome to the Hotel Billing System");

            Console.Write("Enter Room Charge : ");
            roomCharge = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Food Charge : ");
            foodCharge = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Other Charges : ");
            otherCharges = Convert.ToDouble(Console.ReadLine());

            // Calculate total before GST
            totalBeforeGST = roomCharge + foodCharge + otherCharges;

            // Calculate GST amount
            gstAmount = totalBeforeGST * gstRate;

            // Calculate total after GST
            totalAfterGST = totalBeforeGST + gstAmount;

            // Display the bill
            Console.WriteLine("\n----- Hotel Bill -----");
            Console.WriteLine("Room Charge : \t\t" + roomCharge.ToString("C"));
            Console.WriteLine("Food Charge : \t\t" + foodCharge.ToString("C"));
            Console.WriteLine("Other Charges : \t\t" + otherCharges.ToString("C"));
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Total Before GST : \t" + totalBeforeGST.ToString("C"));
            Console.WriteLine("GST (18%): \t\t" + gstAmount.ToString("C"));
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Total After GST : \t" + totalAfterGST.ToString("C"));
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Thank you for staying with us!");
        }
    }

    }

