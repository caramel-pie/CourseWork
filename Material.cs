using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year2_Lab1
{
    internal class Material
    {
        public string material { get; set; }
        public uint cost { get; set; }
        public uint id { get; set; }
        public Material(string material, uint cost, uint id)
        {
            this.material = material;
            this.cost = cost;
            this.id = id;
        }
        public static Material getEmpty
        {
            get { return new Material("", 0, 0); }
        }
        public string ToString()
        {
            return $"{id} {material}";
        }
    }
}
