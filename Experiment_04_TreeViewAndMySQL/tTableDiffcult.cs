using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment_04_TreeViewAndMySQL
{
    class tTableDiffcult
    {
        /// <summary>
        /// 返回所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAll()
        {
            MySqlHelper db = new MySqlHelper();
            return db.ResultSet("SELECT * FROM `mysql`.`ttablediffcult` ORDER BY  `fid` ASC ");
        }

        public DataTable Select(int fid)
        {
            MySqlHelper db = new MySqlHelper();
            return db.ResultSet(string.Format("SELECT * FROM `mysql`.`ttablediffcult` WHERE `fid`={0} ORDER BY  `fid` ASC ", fid));
        }

        public bool updateByID(int fid,string fName,string fRemark){
            MySqlHelper db = new MySqlHelper();

            string sql = string.Format("UPDATE  `mysql`.`ttablediffcult` SET  `fName` =  '{1}',`fRemark` =  '{2}' WHERE  `ttablediffcult`.`fid` ={0}", fid, fName, fRemark);
            try
            {
                if (db.ExecuteSQL(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(int fid, string fName, string fRemark)
        {
            MySqlHelper db = new MySqlHelper();
            string sql = string.Format("INSERT INTO `mysql`.`ttablediffcult`(`fid`,`fName`,`fRemark`) VALUES({0},'{1}','{2}')", fid, fName, fRemark);
            try
            {
                if (db.ExecuteSQL(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int fid)
        {
            MySqlHelper db = new MySqlHelper();
            string sql = string.Format("DELETE FROM `mysql`.`ttablediffcult` WHERE `ttablediffcult`.`fid`={0}", fid);
            try
            {
                if (db.ExecuteSQL(sql))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
