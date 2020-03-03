using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Main_Accounts
    {
        [Key]
        //رقم حساب المخزون الخاص به مثلا 100 هذا للمخزون 100-100 هذ للمجموعة 100100100هذ لللصنف وهكذا

        public int StoreAccount_Id { get; set; }//number account stores and categores 

        public string Description{ get; set; }
        public double Account_Id { get; set; }// الدليل المحاسبي
        public string Account_Name { get; set; }
        public string Center { get; set; }
        public DateTime History { get; set; }//السرية

       
      
    }
}
