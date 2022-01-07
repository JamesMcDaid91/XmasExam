using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasExam
{
    class SeniorMember : Member
    {
        public decimal CalculateFees()
        {
            decimal annualFee = _fee;
            decimal percentageOff = .75m;
            switch (_type)
            {
                case PaymentScedule.annual:
                    annualFee = annualFee/1;
                    annualFee = decimal.Multiply(annualFee, percentageOff);
                    return annualFee;
                case PaymentScedule.biannual:
                    annualFee = annualFee / 2;
                    annualFee = decimal.Multiply(annualFee, percentageOff);
                    return annualFee;
                case PaymentScedule.monthly:
                    annualFee = annualFee / 12;
                    annualFee = decimal.Multiply(annualFee, percentageOff);
                    return annualFee;
                default:
                    return _fee;
            }
        }
    }
}
