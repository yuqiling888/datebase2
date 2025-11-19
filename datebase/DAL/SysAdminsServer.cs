using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL.Models;

namespace DAL
{
    
    /// <summary>
    /// 管理员数据访问类
    /// </summary>
    public class SysAdminsServer
    {
        /// <summary>
        /// 根据登录帐号和密码登录
        /// </summary>
        /// <param name="objAdmin">封装了登录帐号和密码的管理员对象</param>
        /// <returns>返回包含管理员信息的对象</returns>
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            //组全SQL语句
            string sql = "select AdminName from Admins Where LoginId={0} and LoginPwd='{1}'";
            sql = string.Format(sql, objAdmin.LoginId, objAdmin.LoginpPwd);
            //从数据库查询
            SqlDataReader ObjReader = SQLHelper.GetRead(sql);
            if (ObjReader.Read())
            {
                objAdmin.AdminName = ObjReader["AdminName"].ToString();
            }
            //如果登录不成功则把对象清空
            else
                objAdmin = null;
            //关闭读取器
            ObjReader.Close();
            //返回结果
            return objAdmin;

        }
    }
}
