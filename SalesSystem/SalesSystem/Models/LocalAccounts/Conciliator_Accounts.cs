using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.LocalAccounts
{
    public class Conciliator_Accounts
    {
        //الحسابات الوسيطة
        public int Account_Id { get; set; }
        public string Account_Name { get; set; }
        public int MainAccount_Id { get; set; }
        public string Account_Netural { get; set; }
        public string Account_Type { get; set; }
        public string Account_Main { get; set; }
        public string Account_Rank { get; set; }
        public string Account_Groupe { get; set; }
        public string Account_Confidentility { get; set; }//السرية
        public string Account_costCenters { get; set; }
        public string Account_State { get; set; }
    }
}
