using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Editorial_Accounts
{
    public class Editorial_Accounts
    {
        //الحسابات الافتتاحية هي نفسها القيود اليوميةة 
        /// <summary>
        /// Top  يتم من خلال هذه الشاشة ادخال الأرصدة الافتتاحية للحسابات كتالي
        /// </summary>
        [Key]
        public int Move_Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Const_Id { get; set; }
        public virtual Constraints_Type Constraints_Type { get; set; }
        public string Const_Type { get; set; }
        public DateTime History { get; set; }
        public string Const_Comment { get; set; }
        public string M_Name { get; set; }
        public virtual Accounts.Moneys Moneys { get; set; }
        public double Transfer_Price { get; set; }
        public string Communique { get; set; }
        public string Refference { get; set; }

        /// <summary>
        /// Constraint Data
        /// </summary>
        ///
        public int Account_Id { get; set; }
        public virtual Accounts.MainAccounts MainAccounts { get; set; }
        public string Account_Name { get; set; }
        public int Sup_Id { get; set; }
        public int Cust_Id { get; set; }
        /// <summary>
        /// من خلال تحديد رقم الحساب يمكن تحديد مركز التكلفة
        /// </summary>
        public string C_Name { get; set; }
        public double Debtor { get; set; }
        public double Borrower { get; set; }
        public double Equivalent { get; set; }// المكافئ
        public double Debtor_Total { get; set; }
        public double Borrower_Total { get; set; }
        public double Bands { get; set; }//الفارق
        /// <summary>
        //يجب ان يكون الفارق بين المدين والدائن صفر
        /// </summary>
       





    }
}
