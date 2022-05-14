using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resruntPOS_ac0305
{
    class Mealclass
    {
        private int mealnumber;
        private string mealname;
        private string mealtybe;
        private orderclass ordernum;
        public Mealclass()
        {

        }
        public Mealclass(int mealnumber , string mealname, string mealtybe, orderclass ordernum)
        {
            this.mealnumber = mealnumber;
            this.mealname = mealname;
            this.mealtybe = mealtybe;
            this.ordernum = ordernum;
        }
        public int meal_number { get; set; }
        public string meal_name { get; set; }
        public string meal_tybe { get; set; }
        public orderclass order_num { get; set; }
    }
}
