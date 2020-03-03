using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.BillsSetting.BillsVariables
{
    public class AlarmismSetting
    {

        // جدول اعدادد التنبيهات
        public int Id { get; set; }
        public string ArName { get; set; }
        public string EngName { get; set; }
        public int Ala_Time { get; set; }//ومدة التنبية
        public string Ala { get; set; }// هل يوجد تنبية
        public string State { get; set; }
    }
}
