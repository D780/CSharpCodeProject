using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace Experiment_04_TreeViewAndMySQL
{
    class MySqlHelper
    {
        MySqlConnection conn;
        string connStr = string.Format("server={0};Port={1};User Id={2};database={3};password={4};Charset=utf8", "localhost", 3306, "root", "mysql", "");

        /// <summary>
        /// 构造函数
        /// </summary>
        public MySqlHelper()
        {
            if (conn == null)
            {
                try
                {
                    conn = new MySqlConnection(connStr);
                    conn.Open();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("打开数据库异常：" + ee.Message);
                }
            }
            else if (conn.State == ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
            else if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public bool ExecuteSQL(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
               int n= cmd.ExecuteNonQuery();
               if (n > 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 返回数据集
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public DataTable ResultSet(string sql)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return (ds.Tables[0]);
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
