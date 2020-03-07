using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.LocalAccounts
{
    public class ChMove_Type
    {
        //انواع الحركات على الشيكات 
        public int MT_Id { get; set; }
        public virtual ICollection<CheqesWorks> CheqesWorks { get; set; }
        public string MT_Name { get; set; }//نوع الحركة نقد من البنك او شيك تحت التحصيل
    }
}
