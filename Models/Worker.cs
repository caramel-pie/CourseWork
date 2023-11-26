using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Year2_Lab1.Models
{
    class Worker
    {
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime birthday { get; set; }
        public string identification { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
        public string cardnum { get; set; }
        public int position { get; set; }
        public string password { get; set; }
        public int department { get; set; }
        public int id { get; set; }

        public Worker(string name, string surname, DateTime birthday, string identification, string phone, string email, string adress, string cardnum, int position, string password, int department, int id)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
            this.identification = identification;
            this.phone = phone;
            this.email = email;
            this.adress = adress;
            this.cardnum = cardnum;
            this.position = position;
            this.password = password;
            this.department = department;
            this.id = id;
        }
        public static Worker getEmpty
        {
            get { return new Worker("", "", DateTime.Now, "", "", "", "", "", 0, "", 0, 0); }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", name, surname);
        }

    }
}
