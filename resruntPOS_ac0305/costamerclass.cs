using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resruntPOS_ac0305
{
    class costamerclass
    {
        private int costamarID;
        private string costameradress;
        private orderclass costamerorder;
        public costamerclass()
        {

        }
        public costamerclass(int costamarID , string costameradress, orderclass costamerorder)
        {
            this.costamarID = costamarID;
            this.costameradress = costameradress;
            this.costamerorder = costamerorder;
        }
        public int cotamar_ID { get; set; }
        public string cotamaradress { get; set; }
        public orderclass costamer_order { get; set; }

    }
}
