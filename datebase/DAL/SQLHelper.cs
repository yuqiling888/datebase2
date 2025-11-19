using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;  //引入读取配置文件的命名空间
using DAL;


namespace DAL
{
    /// <summary>
    /// 通用数据访问类
    /// </summary>
    public class SQLHelper
    {
        //private static string connString = "SC-202302051042\\TEW_SQL2019;DataBase=StudentManageDB;Uid=sa;Pwd=123";
        //private static string connString = "Server=SC-202302051042\\TEW_SQL2019;Database=StudentManageDB;Integrated Security=True";
        // private static string connString = "Server=SC-202302051042\\TEW_SQL2019;Initial Catalog=StudentManageDB;Integrated Security=SSPI";
        public static readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public static object GetSingleResult(string sql)
        {
            //创建连接对像
            SqlConnection conn = new SqlConnection(connString);
            //创建一个数据库连接实例
            SqlCommand cmd = new SqlCommand(sql, conn);
            //打开连接
            conn.Open();
            object result = cmd.ExecuteScalar();        

            //关闭读取器
           
            conn.Close();
            return result;

         }
        /// <summary>
        /// 更新操作（insert update delete)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //创建一个数据库连接实例
            SqlCommand cmd = new SqlCommand(sql, conn);
            //打开连接
            try
            {
                conn.Open();
                //返回结果
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //将错误信息写入日志.....
                throw ex;
            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }   
        /// <summary>
        /// 返回一个结果集
        /// </summary>
        /// <param name="Sql"></param>
        public static SqlDataReader GetRead(string Sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(Sql, conn);
            conn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            
        }
        
    }
}
