using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasExam
{
    class JuniorMember:Member
    {
        public decimal CalculateFees()
        {
            decimal annualFee = Fee;
            decimal percentageOff = .5m;
            switch (PaymentType)
            {
                case PaymentSchedule.Annual:
                    annualFee = annualFee / 1;
                    annualFee = decimal.Multiply(annualFee, percentageOff);
                    return annualFee;
                case PaymentSchedule.Biannual:
                    annualFee = annualFee / 2;
                    annualFee = decimal.Multiply(annualFee, percentageOff);
                    return annualFee;
                case PaymentSchedule.Monthly:
                    annualFee = annualFee / 12;
                    annualFee = decimal.Multiply(annualFee, percentageOff);
                    return annualFee;
                default:
                    return Fee;
            }
        }
    }
}
