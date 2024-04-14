using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulakatProje_Simfer.Operations.DB
{
    internal class Person
    {
       internal int ID;
       internal string Name;
       internal int Gen;
       internal int? FID_PM;
       internal int? FID_PF;
       internal int BirthYear;
        internal int? Partner_ID;

        public static Person getData(int? r_ID)
        {
            var t = new Person();
            if (r_ID == null)
            {
                return t;
            }           
            var dt = Database.SQL_query("select * from TBL_PERSON where ID = "+r_ID);
            t.ID = (int)r_ID;
            t.Name = dt.Rows[0]["Name"].ToString();
            t.Gen = (int)dt.Rows[0]["Gen"];
            t.FID_PM = Convert.IsDBNull(dt.Rows[0]["FID_PM"]) ? null : (int?)dt.Rows[0]["FID_PM"];
            t.FID_PF = Convert.IsDBNull(dt.Rows[0]["FID_PF"]) ? null : (int?)dt.Rows[0]["FID_PF"];
            t.BirthYear = (int)dt.Rows[0]["BirthYear"];
            t.Partner_ID = Convert.IsDBNull(dt.Rows[0]["Partner_ID"]) ? null : (int?)dt.Rows[0]["Partner_ID"];
            return t;
        }
        public static List<Person> getChild(int? r_ID)
        {
            var dt = Database.SQL_query("select * from TBL_PERSON where FID_PM = " + r_ID+"or FID_PF = "+r_ID);
            var t_list = new List<Person>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var t = new Person();
                t.ID = (int)dt.Rows[i]["ID"];
                t.Name = dt.Rows[i]["Name"].ToString();
                t.Gen = (int)dt.Rows[i]["Gen"];
                t.FID_PM = Convert.IsDBNull(dt.Rows[i]["FID_PM"]) ? null : (int?)dt.Rows[i]["FID_PM"];
                t.FID_PF = Convert.IsDBNull(dt.Rows[i]["FID_PF"]) ? null : (int?)dt.Rows[i]["FID_PF"];
                t.BirthYear = (int)dt.Rows[i]["BirthYear"];
                t.Partner_ID = Convert.IsDBNull(dt.Rows[i]["Partner_ID"]) ? null : (int?)dt.Rows[i]["Partner_ID"];
                t_list.Add(t);
            }
            return t_list;
        }
    }

}
