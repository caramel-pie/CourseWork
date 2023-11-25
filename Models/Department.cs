using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year2_Lab1.Models
{
    internal class Department
    {
        public string opening_time { get; set; }
        public string closing_time { get; set; }
        public string adress { get; set; }
        public uint id { get; set; }
        public Department(string opening_time, string closing_time, string adress, uint id)
        {
            this.opening_time = opening_time;
            this.closing_time = closing_time;
            this.adress = adress;
            this.id = id;
        }
        public static Department getEmpty
        {
            get { return new Department("", "", "", 0); }
        }
        public string ToString()
        {
            return $"{id}) {adress}";
        }
    }
}
