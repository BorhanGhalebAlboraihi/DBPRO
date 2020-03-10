using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Transfer_CommandType
    {
        //انواع اوامر التحويل
        public int TC_Id { get; set; }
        [Key]
        public string TC_Type { get; set; }
        public string State { get; set; }
    }
}
