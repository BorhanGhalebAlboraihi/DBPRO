using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Editorial_Accounts
{
    public class Bonds_Type
    {
        //انواع السندات
        [Key]
        public int B_Id { get; set; }
        public string B_Type { get; set; }
        public string State { get; set; }
        
    }
}
