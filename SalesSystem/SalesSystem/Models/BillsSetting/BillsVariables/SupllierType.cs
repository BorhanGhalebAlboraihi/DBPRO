using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.BillsSetting.BillsVariables
{
    public class SupllierType
    {
      

        public int Id { get; set; }
        [Key]
        public string Sup_Type { get; set; }
        public virtual ICollection<Accounts.Suppliers> Suppliers { get; set; }
        public string EngName { get; set; }
        public int Aressting { get; set; }//طريقة الدفع
        public string Aressting_Name { get; set; }//طريقة الدفع
        public string State { get; set; }
    }
}
