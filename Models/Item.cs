﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year2_Lab1.Models
{
    internal class Item
    {
        public uint material_id { get; set; }
        public string title { get; set; }
        public string condition { get; set; }
        public int pledget { get; set; }
        public int id { get; set; }
        public uint department_id { get; set; }
        public Item(uint material_id, string title, string condition, int pledget, uint department_id, int id)
        {
            this.material_id = material_id;
            this.title = title;
            this.pledget = pledget;
            this.condition = condition;
            this.department_id = department_id;
            this.id = id;
        }
        public static Item getEmpty
        {
            get { return new Item(0, "", "", 0, 0, 0); }
        }
    }
}
