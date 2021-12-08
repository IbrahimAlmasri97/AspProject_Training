using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace firstLevel2.Models
{
    public class UserrInfo
    {
        public string ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public static bool Insert(UserrInfo obj, string connectionString)
        {
            return DB.Insert(obj, connectionString);
        }
        //sqlingtion
        public static bool Login(UserrInfo obj, string connectionString)
        {
            return DB.Login(obj, connectionString);
        }

    }

    public class Emp_Info
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public static List<Emp_Info> reEmpInfo(string connectionString)
        {
            DataTable dt=DB.reEmpInfo(connectionString);
            //to convert list
            List<Emp_Info> emps = ConvertDataTable<Emp_Info>(dt);
            //List<Emp_Info> emps = new List<Emp_Info>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    Emp_Info emp = new Emp_Info();
            //    emp.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
            //    emp.Name = Convert.ToString(dt.Rows[i]["Name"]);
            //    emp.Phone = Convert.ToString(dt.Rows[i]["Phone"]);

            //    emps.Add(emp);
            //}
            return emps;
        }

        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows) 
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();
            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

        public static Emp_Info reEmpInfoByID(int ID ,string connection)
        {
            DataTable dt = DB.reEmpInfoByID(ID,connection);
            //to convert list
            List<Emp_Info> emps = ConvertDataTable<Emp_Info>(dt);
            //List<Emp_Info> emps = new List<Emp_Info>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    Emp_Info emp = new Emp_Info();
            //    emp.ID = Convert.ToInt32(dt.Rows[i]["ID"]);
            //    emp.Name = Convert.ToString(dt.Rows[i]["Name"]);
            //    emp.Phone = Convert.ToString(dt.Rows[i]["Phone"]);

            //    emps.Add(emp);
            //}
            return emps[0];
        }
    }
}
