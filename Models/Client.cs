using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year2_Lab1.Models
{
    internal class Client
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string doctype { get; set; }
        public int docnum { get; set; }
        public string adress { get; set; }
        public int id { get; set; }
        public int telephone { get; set; }
        public string email { get; set; }
        
        public Client(string name, string surname, int age, string doctype, int docnum, string adress, int id, int telephone, string email)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.doctype = doctype;
            this.docnum = docnum;
            this.adress = adress;
            this.id = id;
            this.email = email; 
            this.telephone = telephone;
        }
        public static Client getEmpty
        {
            get { return new Client("", "", 0, "", 0, "", 0, 0, ""); }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", name, surname);
        }
    }
}
