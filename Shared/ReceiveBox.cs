using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoManagment.Shared
{
    public class ReceiveBox
    {

        public int ReceiveBoxID { get; set; }
        [Required]
        public string BoxBarcode { get; set; }
        public DateTime IncomeDate { get; set; }
        public string Staff { get; set; }
        public Department WhereIsTheBox { get; set; }
        public bool IsBoxFinishedToGoOut { get; set; }
        public int BoxNumberWhat { get; set; }
      
    }
}
