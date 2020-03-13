using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.LocalAccounts
{
    public class Exchange__Voucher
    {

        //سند الصرف
        //Top
        [Key]
        public int Move_Id { get; set; }//رقم الحركة
        /// <summary>
        /// طريقة الدفع
        /// </summary>
        public bool Cesh { get; set; }
        public bool Cheque { get; set; }
        public DateTime Vou_History { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int BT_Id { get; set; }
        public virtual Editorial_Accounts.Bonds_Types Bonds_Types { get; set; }
        public string BT_Name { get; set; }// نوع السند
        public bool Const_Comment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int M_Id { get; set; }
        public virtual Accounts.Moneys Moneys { get; set; }
        public string M_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double TransferPrice { get; set; }//سعر الصرف
        public double Communication { get; set; }// المبلغ 
        //Select Cash
        public int Box_Id { get; set; }
        public virtual Accounts.Boxs Boxs { get; set; }
        public string Box_Name { get; set; }
        public string Communique { get; set; }
        public int Refference_Id { get; set; }
        public string Boost { get; set; }//الدافع


        //Select Cheque
        public int Ch_Id { get; set; }
        public virtual Accounts.Banks Banks { get; set; }
        public String Ch_Name { get; set; }
        public string Ch_Communique { get; set; }
        public int Reffe_Id { get; set; }
        public string CT_Name { get; set; }
        public virtual Editorial_Accounts.Cheque_Type Cheque_Type { get; set; }
        public DateTime Deservedness_History { get; set; }//تاريخ الاستحقاق
        public string SMT_Name { get; set; }//طريقة التسديد
        public virtual Al_Purchases.SightMethod_Types SightMethod_Types { get; set; }
             
        /// <summary>
        /// هذا العمود حق المحصل يدخل سواء كان بنك او صندوق
        /// </summary>
        public int S_Id { get; set; }//الموزع
        public virtual BillsSetting.Summation Summation { get; set; }
        public string S_Name { get; set; }
        //Lower

        public int Account_Id { get; set; }
        public virtual Accounts.MainAccounts MainAccounts { get; set; }
        public string Account_Name { get; set; }
        //من خلال تحديد رقم الحساب يتم تحديد اسم المركز
        public string C_Name { get; set; }
        public string A_Communique { get; set; }
        public int Cust_Id { get; set; }
        public virtual Accounts.Customers Customers { get; set; }
        public string Cust_Name { get; set; }
        public DateTime History { get; set; }
        public double Debtors { get; set; }//المبلغ بالنسبة للمدين
        public double Equivalent { get; set; }// المكافئ
      


    }
}
