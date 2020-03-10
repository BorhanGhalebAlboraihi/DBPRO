using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Al_Sales
{
    public class Sales_Commands
    {
        //اوامرالشراء
        [Key]
        public int PCMove_Id { get; set; }//رقم امر الشراء ويجب ان تكون متسلسلةحسب تحديد النظام
        //public virtual ICollection<Purchases__Invoice> Purchases__Invoices { get; set; }
        public string PC_Name { get; set; }
        /// <summary>
        /// نوع الدفع شيك صندوق -اجل
        /// </summary>
        public bool Cash_CheckBox { get; set; }
        public bool Cheque_CheckBox { get; set; }
        public bool Debtor_CheckBox { get; set; }//اجل
                                                 /// <summary>
                                                 /// 
                                                 /// </summary>

        public DateTime History { get; set; }//تاريخ امر الشراء 
        public int PRMove_Id { get; set; } //رقم طلب الشراء
     //   public virtual Purchases_Requerts Purchases_Requerts { get; set; }


        /// <summary>
        /// نوع الحالة اذا كانت نهائي تتم عملية الترحيل ولا عاد يمكن التعديل غير نهائي يمكن
        /// </summary>
        public string ST_Name { get; set; }
       // public virtual States_Types States_Types { get; set; }
        /// <summary>
        /// if select Cash from Box
        /// </summary>
        public int Box_Id { get; set; }
        public virtual Accounts.Boxs Boxs { get; set; }
        public string Box_Name { get; set; }
        /// <summary>
        /// if select Debtor from Supllier
        /// </summary>
        public int Sup_Id { get; set; }
        public virtual Accounts.Suppliers Suppliers { get; set; }
        public string Sup_Name { get; set; }
        public int S_Id { get; set; }
        public virtual Categores_and_Stores.Stores.Stores Stores { get; set; }
        public string S_Name { get; set; }
        public double Transfer_Price { get; set; }
        public double StoreOnPrice { get; set; }//سعر على المخزون
        public int M_Id { get; set; }
        public virtual Categores_and_Stores.Stores.Moneys Moneys { get; set; }
        public string M_Name { get; set; }
        public double Outgonining_Price { get; set; }//سعر الصرف
        public int C_Id { get; set; }
        public virtual Accounts.CostCenters.CostCenter CostCenter { get; set; }
        public string C_Name { get; set; }
        public string Communique { get; set; }
        // public int S_Id { get; set; }
        public virtual BillsSetting.Summation Summation { get; set; }
        public string Summation_Name { get; set; }
        public string Refference { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SG_Id { get; set; }
        public virtual Categores_and_Stores.Stores.Stores_Groupe Stores_Groupe { get; set; }
        public string SG_Name { get; set; }
        public int Cat_Id { get; set; }
        public virtual Categores_and_Stores.Categores.Categores_Data Categores_Data { get; set; }
        public string Cat_Name { get; set; }
        public int U_Id { get; set; }
        public string U_Name { get; set; }
        public int Numbers { get; set; }
        public double Price { get; set; }//السعر
        public double FinalPrice { get; set; }//السعرالنهائي
        public double RequestQuantity { get; set; }//كمية الطلب او عدد الطلب
        public double Price_Top { get; set; }//اعلى سعر
        public double Price_less { get; set; }//اقل سعر
        public double CategoreLower { get; set; }//التخفيض بالنسبة 
        public double FreeLower { get; set; }//التخفيض بالنسبة المجاني
        public double HandLower { get; set; }//التخفيض بالنسبة اليدوي
        public double AllTotal { get; set; }//الاجمالي الكلي بعد التخفيض ولكل
        public double Pure { get; set; }//الصافي
        public double Dust { get; set; }//الضريبة
        public string CategoreCommunique { get; set; }
    }
}
