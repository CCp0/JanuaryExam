using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace January_Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Repository for this exam
            //https://github.com/CCp0/JanuaryExam
            InitializeComponent();
        }
        List<Member> members = new List<Member>();
        List<JuniorMember> jMembers = new List<JuniorMember>();
        List<SeniorMember> sMembers = new List<SeniorMember>();
        List<Member> regMembers = new List<Member>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Member details from moodle
            
            JuniorMember jm1 = new JuniorMember() { Name = "Jack Murphy", Fee = 1000, JoinDate = new DateTime(2020, 5, 7), PaymentType = PaymentSchedule.Annual };
            JuniorMember jm2 = new JuniorMember() { Name = "Emily Kelly", Fee = 1000, JoinDate = new DateTime(2021, 1, 10), PaymentType = PaymentSchedule.Biannual };
            JuniorMember jm3 = new JuniorMember() { Name = "Daniel Ryan", Fee = 1000, JoinDate = new DateTime(2020, 11, 30), PaymentType = PaymentSchedule.Monthly };
            jMembers.Add(jm1);
            jMembers.Add(jm2);
            jMembers.Add(jm3);

            Member m1 = new Member() { Name = "Ella Doyle", Fee = 1000, JoinDate = new DateTime(2019, 3, 20), PaymentType = PaymentSchedule.Annual };
            Member m2 = new Member() { Name = "Fionn Kennedy", Fee = 1000, JoinDate = new DateTime(2018, 8, 15), PaymentType = PaymentSchedule.Biannual };
            Member m3 = new Member() { Name = "Louise Moore", Fee = 1000, JoinDate = new DateTime(2017, 2, 10), PaymentType = PaymentSchedule.Monthly };
            regMembers.Add(m1);
            regMembers.Add(m2);
            regMembers.Add(m3);

            SeniorMember sm1 = new SeniorMember() { Name = "Cian Daly", Fee = 1000, JoinDate = new DateTime(2015, 4, 24), PaymentType = PaymentSchedule.Annual };
            SeniorMember sm2 = new SeniorMember() { Name = "Bobby Quinn", Fee = 1000, JoinDate = new DateTime(2014, 12, 1), PaymentType = PaymentSchedule.Biannual };
            SeniorMember sm3 = new SeniorMember() { Name = "Eve Gallagher", Fee = 1000, JoinDate = new DateTime(2013, 6, 1), PaymentType = PaymentSchedule.Monthly };
            sMembers.Add(sm1);
            sMembers.Add(sm2);
            sMembers.Add(sm3);

            //Adding all details to the members list
            members.Add(jm1);
            members.Add(jm2);
            members.Add(jm3);
            members.Add(m1);
            members.Add(m2);
            members.Add(m3);
            members.Add(sm1);
            members.Add(sm2);
            members.Add(sm3);

            lbxMemberList.ItemsSource = members;//Where the members can be found and displayed
        }

        private void lbxMemberList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Member selected = lbxMemberList.SelectedItem as Member;//The selected members' details can be accessed now
            if (selected != null)
            {
                txtMemberDetails.Text = $"{selected.Name}\nJoin date: {selected.JoinDate.ToShortDateString()}\nBasic fee: €{selected.Fee}\nPayment schedule: {selected.PaymentType} - €{selected.CalculateFees():0.00}\nRenewal date: {selected.RenewalDate().ToShortDateString()}\nDays to renewal: {selected.DaysToRenewal().Days}\n";
            }
        }

        private void radioAll_Checked(object sender, RoutedEventArgs e)
        {
            lbxMemberList.ItemsSource = null;
            lbxMemberList.ItemsSource = members;
        }

        private void radioRegular_Checked(object sender, RoutedEventArgs e)
        {
            lbxMemberList.ItemsSource = null;
            lbxMemberList.ItemsSource = regMembers;
        }

        private void radioSenior_Checked(object sender, RoutedEventArgs e)
        {
            lbxMemberList.ItemsSource = null;
            lbxMemberList.ItemsSource = sMembers;
        }

        private void radioJunior_Checked(object sender, RoutedEventArgs e)
        {
            lbxMemberList.ItemsSource = null;
            lbxMemberList.ItemsSource = jMembers;
        }
    }
}
