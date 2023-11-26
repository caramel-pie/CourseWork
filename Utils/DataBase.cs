using MySql.Data.MySqlClient;
using System.Data;
using Year2_Lab1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Year2_Lab1
{
    internal class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=pawnshop2");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        private static DataBase dbase = new DataBase();
        public static DataBase getInstance
        {
            get
            {
                dbase.openConnection();
                return dbase;
            }
        }
        ~DataBase()
        {
            this.closeConnection();
        }
        public DataSet LoadClientDataset()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `clients` ORDER BY `id`", this.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }
        public DataSet LoadItemDataset()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `items` ORDER BY `id`", this.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }
        public DataSet LoadReceiptDataset()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `receipt` ORDER BY `id`", this.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }
        public int CreateClient(Client client)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `clients` (`name`, `surname`, `age`, `doctype`, `docnum`, `adress`, `telephone`, `email`) VALUES(@n, @s, @age, @dt, @dn, @a, @tel, @em)", this.GetConnection());
            cmd.Parameters.Add("@n", MySqlDbType.VarChar).Value = client.name;
            cmd.Parameters.Add("@s", MySqlDbType.VarChar).Value = client.surname;
            cmd.Parameters.Add("@age", MySqlDbType.Int64).Value = client.age;
            cmd.Parameters.Add("@dt", MySqlDbType.VarChar).Value = client.doctype;
            cmd.Parameters.Add("@dn", MySqlDbType.Int64).Value = client.docnum;
            cmd.Parameters.Add("@a", MySqlDbType.VarChar).Value = client.adress;
            cmd.Parameters.Add("@tel", MySqlDbType.Int64).Value = client.telephone;
            cmd.Parameters.Add("@em", MySqlDbType.VarChar).Value = client.email;
            return cmd.ExecuteNonQuery();
        }
        public int CreateItem(Item item, int oid, Receipt receipt)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `items` (`material_id`, `title`, `pledget`, `condition`, `department_id`) VALUES(@t, @ti, @pg, @con, @dep); SELECT LAST_INSERT_ID();", this.GetConnection());
            cmd.Parameters.Add("@t", MySqlDbType.VarChar).Value = item.material_id;
            cmd.Parameters.Add("@ti", MySqlDbType.VarChar).Value = item.title;
            cmd.Parameters.Add("@pg", MySqlDbType.Int64).Value = item.pledget;
            cmd.Parameters.Add("@con", MySqlDbType.VarChar).Value = item.condition;
            cmd.Parameters.Add("@dep", MySqlDbType.Int64).Value = 1;

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            receipt.itemid = reader.GetInt32(0);
            this.closeConnection();
            this.openConnection();
            Automatization();
            MySqlCommand cmd2 = new MySqlCommand("INSERT INTO `receipt` (`startdate`, `finishdate`, `sum`, `clientid`, `itemid`) VALUES(@sd, @fd, @s, @ci, @ii)", this.GetConnection());
            cmd2.Parameters.Add("@sd", MySqlDbType.DateTime).Value = receipt.startdate;
            cmd2.Parameters.Add("@fd", MySqlDbType.DateTime).Value = receipt.finishdate;
            cmd2.Parameters.Add("@s", MySqlDbType.Int64).Value = item.pledget;
            cmd2.Parameters.Add("@ci", MySqlDbType.VarChar).Value = oid;
            cmd2.Parameters.Add("@ii", MySqlDbType.Int64).Value = receipt.itemid;
            return cmd2.ExecuteNonQuery(); 
        }
        public int CreateWorker(Worker worker)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `workers`(`name`, `surname`, `date_of_birth`, `identif_code`, `telephone`, `email`, `adress`, `cardnum`, `position_id`, `system_password`, `department_id`) VALUES (@n, @s, @bd, @ide, @tel, @em, @ad, @card, @pos, @pas, @dep)", this.GetConnection());
            cmd.Parameters.Add("@n", MySqlDbType.VarChar).Value = worker.name;
            cmd.Parameters.Add("@s", MySqlDbType.VarChar).Value = worker.surname;
            cmd.Parameters.Add("@bd", MySqlDbType.DateTime).Value = worker.birthday;
            cmd.Parameters.Add("@ide", MySqlDbType.VarChar).Value = worker.identification;
            cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = worker.phone;
            cmd.Parameters.Add("@em", MySqlDbType.VarChar).Value = worker.email;
            cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = worker.adress;
            cmd.Parameters.Add("@card", MySqlDbType.Int64).Value = worker.cardnum;
            cmd.Parameters.Add("@pos", MySqlDbType.VarChar).Value = worker.position;
            cmd.Parameters.Add("@pas", MySqlDbType.VarChar).Value = worker.password;
            cmd.Parameters.Add("@dep", MySqlDbType.VarChar).Value = worker.department;
            return cmd.ExecuteNonQuery();
        }
        public bool ClientPresent(int id)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("SELECT `id` FROM `clients` WHERE `id` = @i", this.GetConnection());
            cmd.Parameters.Add("@i", MySqlDbType.Int64).Value = id;
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table.Rows.Count > 0;
        }
        public int DeleteClient(int id)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `clients` WHERE `id` = @id", this.GetConnection());
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = id;
            return cmd.ExecuteNonQuery();
        }
        public int DeleteItem(int id)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `items` WHERE `id` = @id", this.GetConnection());
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = id;
            return cmd.ExecuteNonQuery();
        }
        public int FireWorker(int id)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `workers` WHERE `id` = @id", this.GetConnection());
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = id;
            return cmd.ExecuteNonQuery();
        }
        public int UpdateClientData(Client client)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `clients` SET `name`=@n,`surname`=@s,`age`=@a,`doctype`=@dt,`docnum`=@dn,`adress`=@ad, `telephone`=@tel, `email`=@em WHERE `id`=@id", this.GetConnection());
            cmd.Parameters.Add("@n", MySqlDbType.VarChar).Value = client.name;
            cmd.Parameters.Add("@s", MySqlDbType.VarChar).Value = client.surname;
            cmd.Parameters.Add("@a", MySqlDbType.Int64).Value = client.age;
            cmd.Parameters.Add("@dt", MySqlDbType.VarChar).Value = client.doctype;
            cmd.Parameters.Add("@dn", MySqlDbType.Int64).Value = client.docnum;
            cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = client.adress;
            cmd.Parameters.Add("@tel", MySqlDbType.Int64).Value = client.telephone;
            cmd.Parameters.Add("@em", MySqlDbType.VarChar).Value = client.email;
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = client.id;
            return cmd.ExecuteNonQuery();
        }
        public int UpdateItemData(Item item, Receipt receipt, int oid)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `items` SET `material_id`=@n,`title`=@t,`pledget`=@a,`condition`=@con, `department_id`=@dep WHERE `id`=@id", this.GetConnection());
            cmd.Parameters.Add("@n", MySqlDbType.VarChar).Value = item.material_id;
            cmd.Parameters.Add("@t", MySqlDbType.VarChar).Value = item.title;
            cmd.Parameters.Add("@a", MySqlDbType.Int64).Value = item.pledget;
            cmd.Parameters.Add("@con", MySqlDbType.VarChar).Value = item.condition;
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = item.id;
            cmd.Parameters.Add("@dep", MySqlDbType.Int64).Value = 1;
            cmd.ExecuteNonQuery();

            MySqlCommand cmd2 = new MySqlCommand("UPDATE `receipt` SET `finishdate`=@fd,`sum`=@s,`clientid`=@ci WHERE `itemid`=@ii", this.GetConnection());
            cmd2.Parameters.Add("@fd", MySqlDbType.DateTime).Value = receipt.finishdate;
            cmd2.Parameters.Add("@s", MySqlDbType.Int64).Value = item.pledget;
            cmd2.Parameters.Add("@ci", MySqlDbType.VarChar).Value = oid;
            cmd2.Parameters.Add("@ii", MySqlDbType.Int64).Value = item.id;
            return cmd2.ExecuteNonQuery();
        }
        public int UpdateWorker(Worker worker)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `workers` SET `name`=@n,`surname`=@s,`date_of_birth`=@bd,`identif_code`=@ide,`telephone`=@tel,`email`=@em,`adress`=@ad,`cardnum`=@card,`position_id`=@pos,`system_password`=@pas,`department_id`=@dep WHERE `id`=@id", this.GetConnection());
            cmd.Parameters.Add("@n", MySqlDbType.VarChar).Value = worker.name;
            cmd.Parameters.Add("@s", MySqlDbType.VarChar).Value = worker.surname;
            cmd.Parameters.Add("@bd", MySqlDbType.DateTime).Value = worker.birthday;
            cmd.Parameters.Add("@ide", MySqlDbType.VarChar).Value = worker.identification;
            cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = worker.phone;
            cmd.Parameters.Add("@em", MySqlDbType.VarChar).Value = worker.email;
            cmd.Parameters.Add("@ad", MySqlDbType.VarChar).Value = worker.adress;
            cmd.Parameters.Add("@card", MySqlDbType.Int64).Value = worker.cardnum;
            cmd.Parameters.Add("@pos", MySqlDbType.VarChar).Value = worker.position;
            cmd.Parameters.Add("@pas", MySqlDbType.VarChar).Value = worker.password;
            cmd.Parameters.Add("@dep", MySqlDbType.VarChar).Value = worker.department;
            cmd.Parameters.Add("@id", MySqlDbType.Int64).Value = worker.id;
            return cmd.ExecuteNonQuery();
        }
        public Item GetItem(int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `items` WHERE `id`=@id", this.GetConnection());
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Item item = Item.getEmpty;
            if (dataTable.Rows.Count == 0)
                return item;
            DataRow row = dataTable.Rows[0];
            item.id = id;
            item.material_id = (uint)row["material_id"];
            item.title = row["title"].ToString();
            item.condition = row["condition"].ToString();
            item.pledget = int.Parse(row["pledget"].ToString());
            item.department_id = (uint)row["department_id"];
            return item;
        }
        public Department GetDepartment(uint id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `departments` WHERE `id`=@id", this.GetConnection());
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Department department = Department.getEmpty;
            if (dataTable.Rows.Count == 0)
                return department;
            DataRow row = dataTable.Rows[0];
            department.opening_time = row["opening_time"].ToString();
            department.closing_time = row["closing_time"].ToString();
            department.adress = row["adress"].ToString();
            department.id = id;
            return department;
        }
        public Client GetClient(int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `clients` WHERE `id`=@id", this.GetConnection());
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Client client = Client.getEmpty;
            if (dataTable.Rows.Count == 0)
                return client;
            DataRow row = dataTable.Rows[0];
            client.name = row["name"].ToString();
            client.surname = row["surname"].ToString();
            client.age = Convert.ToInt32(row["age"].ToString());
            client.adress = row["adress"].ToString();
            client.doctype = row["doctype"].ToString();
            client.docnum = Convert.ToInt32(row["docnum"].ToString());
            client.id = id;
            return client;
        }
        public Worker GetWorker(int id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `workers` WHERE `id`=@id", this.GetConnection());
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Worker worker = Worker.getEmpty;
            if (dataTable.Rows.Count == 0)
                return worker;
            DataRow row = dataTable.Rows[0];
            worker.name = row["name"].ToString();
            worker.surname = row["surname"].ToString();
            worker.adress = row["adress"].ToString();
            worker.position = Convert.ToInt32(row["position_id"].ToString());
            worker.email = row["email"].ToString();
            worker.id = id;
            return worker;
        }
        public Receipt GetReceipt(int itemID)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `receipt` WHERE `itemid`=@id", this.GetConnection());
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = itemID;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Receipt receipt = Receipt.getEmpty;
            if (dataTable.Rows.Count == 0)
                return receipt;
            DataRow row = dataTable.Rows[0];
            receipt.id = int.Parse(row["id"].ToString());
            receipt.startdate = (DateTime)row["startdate"];
            receipt.finishdate = (DateTime)row["finishdate"];
            receipt.sum = int.Parse(row["sum"].ToString());
            receipt.clientid = int.Parse(row["clientid"].ToString());
            receipt.itemid = itemID;
            return receipt;
        }
        public DataSet QueriesDataset(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, this.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }
        public List<Material> MaterialChoice()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `materials`", this.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            List<Material> materials = new List<Material>();
            foreach (DataRow row in dataTable.Rows)
            {
                Material material = Material.getEmpty;
                material.material = row["material"].ToString();
                material.cost = (uint)row["cost"];
                material.id = (uint)row["id"];
                materials.Add(material);
            }
            return materials;
        }
        public List<Department> DepartmentChoice()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `departments`", this.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            List<Department> departments = new List<Department>();
            foreach (DataRow row in dataTable.Rows)
            {
                Department department = Department.getEmpty;
                department.opening_time = row["opening_time"].ToString();
                department.closing_time = row["closing_time"].ToString();
                department.adress = row["adress"].ToString();
                department.id = (uint)row["id"];
                departments.Add(department);
            }
            return departments;
        }
        public List<String> GetConditions()
        {
            List<String> conditions = new List<String>();
            conditions.Add("New");
            conditions.Add("Used");
            conditions.Add("To repair");
            return conditions;
        }
        public DataSet ClientsItems(uint id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT `items`.`id`, `title` from `items` INNER JOIN `receipt` on `items`.`id` = `receipt`.`itemid` WHERE `receipt`.`clientid` = @ci", this.GetConnection());
            cmd.Parameters.Add("@ci", MySqlDbType.Int32).Value = id;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet items = new DataSet();
            adapter.Fill(items);
            return items;
        }
        public int Login(int id, string password)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT `system_password`, `position_id` FROM `workers` WHERE `id`=@id", this.GetConnection());
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataRow row = dataTable.Rows[0];
            var system_password = row["system_password"].ToString();
            if (system_password == password)
            {
                return int.Parse(row["position_id"].ToString());
            }
            return 0;

        }
        public void Automatization()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT `department_id`, COUNT(`id`) AS 'cou' FROM `items` GROUP BY `department_id`", this.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            Dictionary<uint, uint> data = new Dictionary<uint, uint>();
            foreach (DataRow row in dataTable.Rows)
            {
                data.Add(uint.Parse(row["department_id"].ToString()), uint.Parse(row["cou"].ToString()));
            }
            var division = data.Values.Aggregate((a, b) => a + b) / data.Count;
            MessageBox.Show(division.ToString());
            MySqlCommand cmdUPD = new MySqlCommand("UPDATE `items` JOIN (SELECT `id` FROM `items` WHERE `department_id` = @fdit LIMIT 1) AS subquery ON `items`.`id` = subquery.`id` SET `items`.`department_id` = @deid", this.GetConnection());
            foreach (uint i in data.Keys)
            {
                while (data[i] > division + 1)
                {
                    try
                    {
                        // Find a department with a count less than division - 1
                        var toid = data.Where(a => a.Value < division - 1).OrderByDescending(a => a.Value).FirstOrDefault().Key;

                        // Check if a suitable department was found
                        if (toid != 0)
                        {
                            cmdUPD.Parameters.Clear(); // Clear existing parameters
                            cmdUPD.Parameters.Add("@deid", MySqlDbType.Int32).Value = toid;
                            cmdUPD.Parameters.Add("@fdit", MySqlDbType.Int32).Value = i;
                            cmdUPD.ExecuteNonQuery();
                            data[i]--;
                            data[toid]++;
                        }
                        else
                        {
                            // Break the loop if no suitable department is found
                            break;
                        }
                    }
                    catch
                    {
                        // Handle exceptions if needed
                        break;
                    }
                }
            }

        }
    }
}
