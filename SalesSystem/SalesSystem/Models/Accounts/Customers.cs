using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class Customers
    {
        [Key]
        public int Cust_Id { get; set; }
       public virtual ICollection<Categores_and_Stores.Categores.Store_Outgoings> Store_Outgoings { get; set; }
        public virtual ICollection<Categores_and_Stores.Categores.Store_Resource> Store_Resources { get; set; }
        public virtual ICollection<LocalAccounts.Exchange__Voucher> Exchange__Vouchers { get; set; }
        public virtual ICollection<LocalAccounts.Bank_Deposited> Bank_Depositeds { get; set; }
        public virtual ICollection<Al_Sales.Sales_Invoice> Sales_Invoices { get; set; }
        public string Cust_Name { get; set; }
        public int Cust_MainAccountNB { get; set; }
        public string Cust_Rank { get; set; }
        public string Cust_Address { get; set; }
        public string Cust_Netuarl { get; set; }
        public string Cust_State { get; set; }
        public double Cust_phone { get; set; }
        public DateTime Cust_History { get; set; }
        public string Cust_SalePrice { get; set; }//سعر البيع للعميل
        public string Cust_SaleMoney { get; set; }//عملة البيع للعميل
        public double Cust_DebtorsTop { get; set; }//اعلى مديونية للعميل
        public string Cust_DebtorsTime { get; set; }
       
        public string Country { get; set; }
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Cust_Type { get; set; }
        public virtual BillsSetting.BillsVariables.CustomersType CustomersType { get; set; }
        public int S_Id { get; set; }//الموزع
        public virtual BillsSetting.Summation Summation { get; set; }
        public string S_Name { get; set; }//الموزع
        public int Account_Id{ get; set; }// الدليل المحاسبي
        public virtual MainAccounts Accounts { get; set; }
        //  public int A_Id { get; set; }
        public virtual BillsSetting.SalesAreas SalesAreas { get; set; }
       public string M_Name { get; set; }
        public virtual Moneys Moneys { get; set; }



    }
}
