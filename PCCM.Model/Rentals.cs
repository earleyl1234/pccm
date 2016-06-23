using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCM.Web.Model
{
    public class Rentals
    {
        public int RentalId { get; set; }
        public DateTime? RentalBeginDate { get; set; }
        public DateTime? RentalEndDate { get; set; }
        public bool WillDrink { get; set; }
        public bool WillDance { get; set; }
    }
}
