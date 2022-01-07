using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January_Exam
{
    class SeniorMember: Member
    {
        public override decimal CalculateFees()
        {
            decimal calculatedFees = Fee * 0.75m; //Annual fee at 75% less than regular members
            if (PaymentType == PaymentSchedule.Biannual)
            {
                calculatedFees = Fee * 2; //Biannual fee
            }
            else if (PaymentType == PaymentSchedule.Monthly)
            {
                calculatedFees = Fee / 12; //Monthly fee
            }
            return calculatedFees;
        }
    }
}
