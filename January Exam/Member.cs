using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January_Exam
{
    class Member
    {
        public Member() //Constructor
        {
        }
        //Properties
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal Fee { get; set; }
        public PaymentSchedule PaymentType { get; set; }
        //Computed properties Q1(e)
        public DateTime RenewalDate()
        {
            // the next occurrence of the day and month of the join date
            DateTime renewalDate = DateTime.Now;//Current date is default
            if(PaymentType == PaymentSchedule.annual)
            {
                renewalDate = JoinDate.AddYears(1);//1 year post joining
            }
            else if(PaymentType == PaymentSchedule.biannual)
            {
                renewalDate = JoinDate.AddYears(2);//2 years post joining
            }
            else if(PaymentType == PaymentSchedule.monthly)
            {
                renewalDate = JoinDate.AddMonths(1);//1 month post joining
            }
            return renewalDate;
        }
        public TimeSpan DaysToRenewal()
        {
            TimeSpan daysToRenewal;
            daysToRenewal = JoinDate.Subtract(RenewalDate()); //Takes the renewal date away from the join date to find how many days are left before the first renewal
            return daysToRenewal;
        }
        public decimal CalculateFees()
        {
            if (PaymentType == PaymentSchedule.annual)
            {

            }
            else if (PaymentType == PaymentSchedule.biannual)
            {

            }
            else if (PaymentType == PaymentSchedule.monthly)
            {

            }
        }
        public override string ToString()
        {
            return $"{Name}\nJoin date: {JoinDate}\nBasic fee: {Fee}\nPayment schedule: {PaymentType}\nRenewal date: {RenewalDate()}\nDays to renewal: {DaysToRenewal()}\n";
        }
    }
    public enum PaymentSchedule //Accessible in all cs files
    {
        annual,
        biannual,
        monthly
    }
}
