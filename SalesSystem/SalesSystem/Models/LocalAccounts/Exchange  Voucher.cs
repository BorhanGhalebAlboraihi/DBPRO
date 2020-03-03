using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.LocalAccounts
{
    public class Exchange__Voucher
    {

        //سند الصرف
        //Top
        public DateTime Vou_History { get; set; }
        public int Vou_Number { get; set; }
        public int CostCenter_Id { get; set; }
        public int Money { get; set; }
        public int Process_Id { get; set; }
        public int TransferPrice { get; set; }//سعر الصرف
        public double Communication { get; set; }// المبلغ 
        //Select Cash
        public int Box_Id { get; set; }
        public String Box_Name { get; set; }
        public string Communique { get; set; }
        public int Refference_Id { get; set; }
        public String Boost { get; set; }//الدافع
        public int Summation_Id { get; set; }//الموزع

        //Select Cheque
        public int Ch_Id { get; set; }
        public String Ch_Name { get; set; }
        public string Ch_Communique { get; set; }
        public int Reffe_Id { get; set; }
        public string Ch_Type { get; set; }
        public DateTime Deservedness_History { get; set; }//تاريخ الاستحقاق
        public string Sight_Method { get; set; }//طريقة التسديد
        public int Summation { get; set; }//الموزع

        //Lower

        public int Account_Id { get; set; }
        public string Account_Name { get; set; }
        public string A_Communique { get; set; }
        public double A_Communication { get; set; }
        public int Cust_Id { get; set; }
        public string Cust_Name { get; set; }
        public DateTime History { get; set; }
        public double Debtors { get; set; }//المبلغ بالنسبة للمدين


    }
}
