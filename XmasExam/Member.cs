using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasExam
{
    public enum PaymentSchedule
    {
        Annual = 1,
        Biannual = 2,
        Monthly = 12,
    }
    class Member
    {
        //properties
        public string Name;
        public DateTime JoinDate;
        public decimal Fee;
        public PaymentSchedule PaymentType;
        //calculated properties
        public DateTime RenewalDate()
        {
            return new DateTime(JoinDate.Year +1,JoinDate.Month,JoinDate.Day); //this will mess up on leap days
        }
        public int DaysToRenewal()
        {
            return (RenewalDate() - DateTime.Now).Days;             
        }
        //methods
        public decimal CalculateFees()
        {
            switch (PaymentType)
            {
                case PaymentSchedule.Annual:
                    return Fee / 1;                    
                case PaymentSchedule.Biannual:
                    return Fee / 2;                    
                case PaymentSchedule.Monthly:
                    return Fee / 12;                  
                default:
                    return Fee;
            } 
        }

    }
}
