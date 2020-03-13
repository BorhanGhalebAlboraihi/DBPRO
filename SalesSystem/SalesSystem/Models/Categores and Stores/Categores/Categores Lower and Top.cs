using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Categores_Lower_and_Top
    {
        //التخفيضات والزيادة للأصناف
        /// </summary>
        public int SG_Id { get; set; }
        public virtual Categores_and_Stores.Stores.Stores_Groupe Stores_Groupe { get; set; }
        public string SG_Name { get; set; }
        public int Cat_Id { get; set; }
        public virtual Categores_and_Stores.Categores.Categores_Data Categores_Data { get; set; }
        public string Cat_Name { get; set; }
        /// <summary>
        /// Section 
        /// </summary>
        [Key]
        public int CLTMove_Id { get; set; }
        public int U_Id { get; set; }
        public virtual Stores.Stores_Units Stores_Units { get; set; }
        public string U_Name { get; set; }
        public int Numbers { get; set; }
        public string DT_Name { get; set; }
        public virtual Displaies_Types Displaies_Types { get; set; }
        public double Ascription { get; set; }//النسبة التخفيضية والعدد المجاني و الزياده 
        public double OneAll { get; set; }//النسبة لكل وحده اذا كان كرتون
        public DateTime From_History { get; set; }
        public DateTime To_History { get; set; }
        public string DST_Name { get; set; }
        public virtual Categores_Lower_and_Top Categores_Lower_And_Top { get; set; }
        public string Details { get; set; }

    }
}
