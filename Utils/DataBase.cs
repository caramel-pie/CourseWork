using MySql.Data.MySqlClient;
using System.Data;
using Year2_Lab1.Models;

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
            MySqlCommand cmd2 = new MySqlCommand("INSERT INTO `receipt` (`startdate`, `finishdate`, `sum`, `clientid`, `itemid`) VALUES(@sd, @fd, @s, @ci, @ii)", this.GetConnection());
            cmd2.Parameters.Add("@sd", MySqlDbType.DateTime).Value = receipt.startdate;
            cmd2.Parameters.Add("@fd", MySqlDbType.DateTime).Value = receipt.finishdate;
            cmd2.Parameters.Add("@s", MySqlDbType.Int64).Value = item.pledget;
            cmd2.Parameters.Add("@ci", MySqlDbType.VarChar).Value = oid;
            cmd2.Parameters.Add("@ii", MySqlDbType.Int64).Value = receipt.itemid;
            return cmd2.ExecuteNonQuery(); 
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

    }
}
