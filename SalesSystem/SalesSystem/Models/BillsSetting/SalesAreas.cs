using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.BillsSetting
{// جدول نقاط البيع
    public class SalesAreas
    {     [Key]
        public int A_Id { get; set; }
        public virtual ICollection<Summation> Summations { get; set; }
        public virtual ICollection<Accounts.Customers> Customers { get; set; }
        public virtual ICollection<Accounts.Suppliers> Suppliers { get; set; }
        public virtual ICollection<Accounts.Employees> Employees { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Location { get; set; }
        public DateTime History { get; set; }
        public string State { get; set; }

    }
}
