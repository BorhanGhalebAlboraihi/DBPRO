using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.LocalAccounts
{
    public class EmployeeMove_Type
    {
        //انواع حركات الموظف
        public int EM_Id { get; set; }
        public virtual ICollection<Employees_Activity> Employees_Activities { get; set; }
        public string EM_Type { get; set; }
        public string AS_Name { get; set; }
        public virtual Accounts.AccountsVariarble.Accounts_state Accounts_State { get; set; }
        public string M_Name { get; set; }
        public virtual Accounts.Moneys Moneys { get; set; }
        public double Month { get; set; }
        public double Year { get; set; }
        public string Communique { get; set; }
        public DateTime History { get; set; }
        public int C_Id { get; set; }
        public virtual Accounts.CostCenters.CostCenter CostCenter { get; set; }
        public string C_Name { get; set; }
    }
}
