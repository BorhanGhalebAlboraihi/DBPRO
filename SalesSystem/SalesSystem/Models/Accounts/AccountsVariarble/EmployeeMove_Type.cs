using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts.AccountsVariarble
{
    public class EmployeeMove_Type
    {
        //انواع حركات الموظف
        public int Id { get; set; }
        public string B_Type { get; set; }
        public string State { get; set; }
        public string M_Name { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Communique { get; set; }
        public DateTime History { get; set; }
        public string C_Name { get; set; }
    }
}
