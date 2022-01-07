using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January_Exam
{
    class JuniorMember: Member
    {
        public override decimal CalculateFees()
        {
            decimal calculatedFees = Fee * 0.5m; //Annual fee at 50% less than regular members
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
