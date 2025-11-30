using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.DAL
{
    public class StudentService
    {
        #region 添加学员对象
        public bool IsIdNoExisted(string studentIdNo)
        {
            string sql = "select count(*) from Students where StudentIdNo={0}";
            sql = string.Format(sql, studentIdNo);
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (result == 1) return true;
            else return false;
        }
        public int AddStudent(Students objStudent)
        {
            //编写SQL语句
            StringBuilder sqlbuilder = new StringBuilder();
            sqlbuilder.Append("insert into Studens(StudentId,StudentName,Gender,Birthday," +
                "StudentIdNo,Age,PhoneNumber,StudentAdddress,ClassId)");
            sqlbuilder.Append(" values({0},'{1}','{2}','{3}',{4},{5},'{6}','{7}',{8})");
            //解析对象
            string sql = string.Format(sqlbuilder.ToString(), objStudent.StudentId,
                objStudent.StudentName, objStudent.Gender, objStudent.Birthday,
                objStudent.StudentIdNo, objStudent.Age, objStudent.PhoneNumber, 
                objStudent.StudentAddress, objStudent.ClassId);
            //提交到据库
            try
            {
                return SQLHelper.Update(sql);

            }
            catch (SqlException ex)
            {

                throw;
            }
            catch(Exception ex)
            {

            }
         }

        #endregion
    }
}
