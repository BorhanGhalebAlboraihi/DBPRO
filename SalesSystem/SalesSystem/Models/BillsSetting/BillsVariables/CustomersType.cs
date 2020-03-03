using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.BillsSetting.BillsVariables
{
    public class CustomersType
    {
       
        public int Id { get; set; }
        [Key]
        public string Cust_Type { get; set; }
        public virtual ICollection<Accounts.Customers> Customers { get; set; }
        public string EngName { get; set; }
        public int Aressting { get; set; }//طريقة الدفع
        public string Aressting_Name { get; set; }//طريقة الدفع
        public double CommunicationTop { get; set; }// مبلغ التجاوز
        public string State { get; set; }
    }
}
