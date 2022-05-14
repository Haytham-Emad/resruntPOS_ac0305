using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resruntPOS_ac0305
{
    class orderclass
    {
        private int ordernum;
        private string ordername ;
        private string ordertybe;
        public orderclass()
        {

        }
        public orderclass(int ordernum , string ordername , string ordertybe)
        {
            this.ordernum = ordernum;
            this.ordername = ordername;
            this.ordertybe = ordertybe;
        }
        public  int order_num { get; set; }
        public string order_name { get; set; }
        public string order_tybe { get; set; }
    }
}
