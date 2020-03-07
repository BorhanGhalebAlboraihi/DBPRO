using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.LocalAccounts
{
    public class OutgoningnessMove_Type
    {
       
        public int OUT_Id { get; set; }
        [Key]
        public string OUT_Name { get; set; }//اسم نوع الحركة
        public virtual ICollection<Outgoningness> Outgoningnesses { get; set; }
    }
}
