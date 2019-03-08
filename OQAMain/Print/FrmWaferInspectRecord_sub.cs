using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OQAMain.Print
{

    public class WaferInspectRecord_sub
    {
        public WaferInspectRecord_sub(string d1, string d2, string d3, string d4, string d5)
        {
            Defect01 = d1;
            Defect02 = d2;
            Defect03 = d3;
            Defect04 = d4;
            Defect05 = d5;
            
        }
        public string Defect01 { get; set; }
        public string Defect02 { get; set; }
        public string Defect03 { get; set; }
        public string Defect04 { get; set; }
        public string Defect05 { get; set; }
       

    }
}
