using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year2_Lab1
{
    internal class Receipt
    {
        public DateTime startdate { get; set; }
        public DateTime finishdate { get; set; }
        public int sum { get; set; }
        public int clientid { get; set; }
        public int itemid { get; set; }
        public int id { get; set; }

        public Receipt(DateTime startdate, DateTime finishdate, int sum, int clientid, int itemid, int id)
        {
            this.startdate = startdate;
            this.finishdate = finishdate;
            this.sum = sum;
            this.clientid = clientid;
            this.itemid = itemid;
            this.id = id;
        }
        public static Receipt getEmpty
        {
            get { return new Receipt(DateTime.Now, DateTime.Now, 0, 0, 0, 0); }
        }
    }
}
