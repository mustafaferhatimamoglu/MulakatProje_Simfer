using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulakatProje_Simfer.Operations
{
    internal class Database
    {
        public static bool Person_Add(string Name, int Gen
           , int? FID_PM
           , int? FID_PF
           , int BirthYear)
        {
            SQL_query(@"INSERT INTO [dbo].[TBL_Person]
           ([Name]
           ,[Gen]
           ,[FID_PM]
           ,[FID_PF]
           ,[BirthYear])
     VALUES
           (" + Name + @"
           ,"+ Gen.ToString() + @"
           ," + FID_PM.ToString() + @"
           ,"+ FID_PF.ToString() + @"
           ,"+ BirthYear.ToString() + @")");
            return true;
        }
        public static string SQLCon = "Data Source=" + "localhost" +
                    "; Initial Catalog=" + "SIMFER_AILE" +
                    "; USER ID=" + "sa" +
                    ";PASSWORD=" + "sapass" + "";

        public static DataTable SQL_query(string SQL_Query)
        {
            using (SqlConnection connect = new SqlConnection(SQLCon + ";Connect Timeout=60;Persist Security Info=True;MultipleActiveResultSets=true;"))
            {
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(SQL_Query, connect))
                {
                    try
                    {
                        da.Fill(dt);
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("There is already an object named"))
                        {
                            return dt;
                        }
                        else if (ex.Message.Contains("Error converting data type varchar to numeric."))
                        {
                            MessageBox.Show("aaaaaaaaaaaaaaaaaaa");
                            return dt;
                        }
                        else
                        {
                            return dt;
                        }
                    }
                }
            }
        }
    }
}
