using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBillCalculator
{
    internal class WaterBill
    {
        public string name { get; set; }
        public int type { get; set; }
        public double lastMonth { get; set; }
        public double thisMonth { get; set; }
        public int numberPeople { get; set; }
        // thisMonth - lastMonth
        public double usage { get; set; }
        // how much money you must pay 
        public double totalCost { get; set; }
        public string dateTime { get; set; }
    }
}
