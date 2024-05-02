using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoManagment.Shared
{
    public class EnveloopExtract
    {
        public int EnveloopExtractID { get; set; }
        public string EnveloopBarcode { get; set; }
        public string  BoxBarcode { get; set; }
        public Department WhereISEnveloop { get; set; }
        public bool IsAnyProblemWhitEnveloop { get; set; }
        public int ReceiveBoxID { get; set; }
        public string Staff { get; set; }
        public DateTime StartTime { get; set; }
   


    }
}
