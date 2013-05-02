using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
            return db.ResultSet("SELECT * FROM `ttablediffcult` ORDER BY  `fid` ASC ");
        }

        public DataTable Select(int fid)
        {
            MySqlParameter[] param = { new MySqlParameter("@fid", MySqlDbType.Int32) };
            param[0].Value = fid;
            MySqlHelper db = new MySqlHelper();
            string sql = "SELECT * FROM `ttablediffcult` WHERE `fid`=@fid ORDER BY  `fid` ASC ";
            return db.ResultSet(sql, param);
        }

        public bool updateByID(int fid, string fName, string fRemark)
        {
            MySqlParameter[] param ={                                 
                                   new MySqlParameter("@fName",MySqlDbType.Text),
                                   new MySqlParameter("@fRemark",MySqlDbType.Text),   
                                   new MySqlParameter("@fid",MySqlDbType.Int32),                                 
                                   };
            param[0].Value = fName;
            param[1].Value = fRemark;
            param[2].Value = fid;
            MySqlHelper db = new MySqlHelper();
            string sql ="UPDATE  `ttablediffcult` SET  `fName` =  @fName,`fRemark` = @fRemark WHERE  `ttablediffcult`.`fid` =@fid";
            try
            {
                if (db.ExecuteSQL(sql,param))
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
            MySqlParameter[] param ={      
                                   new MySqlParameter("@fid",MySqlDbType.Int32),    
                                   new MySqlParameter("@fName",MySqlDbType.Text),
                                   new MySqlParameter("@fRemark",MySqlDbType.Text),                                                                   
                                   };
            param[0].Value = fid;
            param[1].Value = fName;
            param[2].Value = fRemark;            
            MySqlHelper db = new MySqlHelper();
            string sql = "INSERT INTO `ttablediffcult`(`fid`,`fName`,`fRemark`) VALUES(@fid,@fName,@fRemark)";
            try
            {
                if (db.ExecuteSQL(sql,param))
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
            MySqlParameter[] param = { new MySqlParameter("@fid", MySqlDbType.Int32) };
            param[0].Value = fid;
            MySqlHelper db = new MySqlHelper();
            string sql = "DELETE FROM `ttablediffcult` WHERE `ttablediffcult`.`fid`=@fid";
            try
            {
                if (db.ExecuteSQL(sql,param))
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
