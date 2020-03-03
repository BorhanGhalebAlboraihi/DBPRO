﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Swap_Categores
    {
        public int SG_Id { get; set; }//Swap Groupe id
        public string SG_Name { get; set; }//Swap Groupe Name
        public int Cat_Id { get; set; }
        public string Cat_Name { get; set; }
        public double Price { get; set; }
        public DateTime BreakingHistory { get; set; }
        public string State { get; set; }
        public string Rank { get; set; }
    }
}