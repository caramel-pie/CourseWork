﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year2_Lab1.Utils
{
    public class Stats
    {
        public static DataSet getGeneralValue()
        {
            var value = DataBase.getInstance.QueriesDataset("SELECT adress, SUM(receipt.sum) AS sum_sum FROM departments JOIN items ON departments.id = items.department_id JOIN receipt ON items.id = receipt.itemid WHERE receipt.itemid IS NOT NULL GROUP BY departments.adress HAVING sum(receipt.sum) >= ALL ( SELECT SUM(receipt.sum) FROM receipt JOIN items ON items.id = receipt.itemid WHERE receipt.itemid IS NOT NULL GROUP BY department_id ) ORDER BY sum_sum DESC;");
            return value;
        }
        public static DataSet getCountByMaterial()
        {
            var value = DataBase.getInstance.QueriesDataset("SELECT departments.adress, materials.material, COUNT(items.id) AS cou FROM items JOIN materials ON items.material_id = materials.id JOIN departments ON items.department_id = departments.id GROUP BY departments.adress, materials.material ORDER BY cou DESC, departments.adress;");
            return value;
        }


    }
}
