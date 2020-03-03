using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts.CostCenters
{
    public class CostCenter
    {
        [Key]
        public int C_Id { get; set; }
        public string C_Name { get; set; }
        public int MainCenter_Id { get; set; }
        /// <summary>
        /// Foreign Key with Type
        /// </summary>
        public string CT_Name { get; set; }//رائيسي او فرعي
        public virtual Cost_Centers_Type Cost_Centers_Type { get; set; }
        /// <summary>
        /// Foreign Key with Rank
        /// </summary>
        public int CR_Id { get; set; }
        public virtual CostCenter_Rank CostCenter_Rank { get; set; }
        /// <summary>
        /// Foreign Key with Groupe
        /// </summary>
        public string CG_Name { get; set; }
        public virtual CostCenters_Groupe CostCenters_Groupe { get; set; }
        /// <summary>
        ///  Foreign Key with State
        /// </summary>
        public string CS_Name { get; set; }
        public virtual CostCenters_State CostCenters_State { get; set; }




    }
}
