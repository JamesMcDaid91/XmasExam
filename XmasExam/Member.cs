using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasExam
{
    enum PaymentScedule
    {
        annual = 1,
        biannual = 2,
        monthly = 12,
    }
    class Member
    {
        //properties
        private string _name;
        private DateTime _joinDate;
        private decimal _fee;
        private PaymentScedule _type;
        //calculated properties
        public DateTime RenewalDate()
        {
            return new DateTime(_joinDate.Year +1,_joinDate.Month,_joinDate.Day); //this will mess up on leap days
        }
        public int DaysToRenewal()
        {
            return (RenewalDate() - DateTime.Now).Days;             
        }
        //methods
        public decimal CalculateFees()
        {
            switch (_type)
            {
                case PaymentScedule.annual:
                    return _fee / 1;                    
                case PaymentScedule.biannual:
                    return _fee / 2;                    
                case PaymentScedule.monthly:
                    return _fee / 12;                  
                default:
                    return _fee;
            } 
        }
    }
}
