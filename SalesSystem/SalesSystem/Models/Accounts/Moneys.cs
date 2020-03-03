using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class Moneys
    {
      
       
        public int _Id { get; set; }
        [Key]
        public string M_Name { get; set; }
        public virtual ICollection<Banks> Banks { get; set; }
        public virtual ICollection<Boxs> Boxs { get; set; }
        public virtual ICollection<MainAccounts> MainAccounts { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Suppliers> Suppliers { get; set; }
        public virtual ICollection <Editorial_Accounts.Editorial_Accounts> Editorial_Accounts { get; set; }
        public string M_Symbole { get; set; }
        public string M_Barket { get; set; }//الفئة
        public double M_Pric { get; set; }// سعر تحويل
        public double M_PriceTop { get; set; }//اعلى سعر تحويل
        public double M_PriceLess { get; set; }//اقل سعر تحويل
        public string M_Country { get; set; }
        public string M_State { get; set; }
        public string M_Type { get; set; }
        public DateTime M_History { get; set; }
    }
}
