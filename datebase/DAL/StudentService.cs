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
    public class StudentService
    {
        #region 添加学员对象
        /// <summary>
        /// 查询是否己存在身份证信息
        /// </summary>
        /// <param name="studentIdNo"></param>
        /// <returns></returns>
        public bool IsIdNoExisted(string studentIdNo)
        {
            string sql = "select count(*) from Students where StudentIdNo={0}";
            sql = string.Format(sql, studentIdNo);
            int result = Convert.ToInt32(SQLHelper.GetSingleResult(sql));
            if (result == 1) return true;
            else return false;
        }
        /// <summary>
        /// 添加学员
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        public int AddStudent(Students objStudent)
        {
            //【1】编写SQL语句
            StringBuilder sqlbuilder = new StringBuilder();
            sqlbuilder.Append("insert into Students(StudentName,Gender,Birthday," +
                "StudentIdNo,Age,PhoneNumber,StudentAddress,ClassId)");
            sqlbuilder.Append(" values('{0}','{1}','{2}',{3},{4},'{5}','{6}',{7})");
            //【2】解析对象
            string sql = string.Format(sqlbuilder.ToString(), 
                objStudent.StudentName, objStudent.Gender, objStudent.Birthday,
                objStudent.StudentIdNo, objStudent.Age, objStudent.PhoneNumber, 
                objStudent.StudentAddress, objStudent.ClassId);
            //【3】提交到据库
            try
            {
                return SQLHelper.Update(sql);

            }
            catch (SqlException ex)
            {

                throw new Exception("数据库操作异常，具体原因"+ex.Message);
            }
            catch(Exception ex)
            {
                throw ex;

            }
         }

        #endregion
        #region 查询学员
        /// <summary>
        /// 根据班级查询学员
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public List<ExtStudent> GetStudentByClass(string ClassName)
        {
            string sql = "select StudentId,StudentName,Gender,Birthday,StudentClass.ClassName from students";
            sql += " inner join StudentClass on Students.ClassId=StudentClass.ClassId";
            sql += " where StudentClass.ClassName='{0}'";
            sql = string.Format(sql, ClassName);
            SqlDataReader objRead = SQLHelper.GetReader(sql);
            List<ExtStudent> list = new List<ExtStudent>();
            while(objRead.Read())
            {
                list.Add(new ExtStudent()
                {
                    StudentId = Convert.ToInt32(objRead["StudentId"]),
                    StudentName = objRead["StudentName"].ToString(),
                    Gender = objRead["Gender"].ToString(),
                    Birthday = Convert.ToDateTime(objRead["Birthday"]),
                    ClassName = objRead["ClassName"].ToString()
                }) ;
            }
            objRead.Close();
            return list;
        }
        /// <summary>
        /// 根据学号查询学员信息
        /// </summary>
        /// <param name="StudentId"></param>
        /// <returns></returns>
        public ExtStudent GetStudentByStudentId(string StudentId)
        {
            string sql = "select StudentName,Gender,Birthday,StudentIdNo,";
            sql += "Age,PhoneNumber,StudentAddress,StudentClass.ClassId,StudentClass.ClassName,CardNo from Students";
            sql += " inner join StudentClass on Students.ClassId=StudentClass.ClassId ";
            sql += " where StudentId={0}";
            sql = string.Format(sql, StudentId);
            SqlDataReader objRead = SQLHelper.GetReader(sql);
            ExtStudent objExtStudent = null;
            if(objRead.Read())
            {
                objExtStudent = new ExtStudent()
                {
                  
                    StudentName = objRead["StudentName"].ToString(),
                    Gender = objRead["Gender"].ToString(),
                    Birthday = Convert.ToDateTime(objRead["Birthday"]),
                    StudentIdNo = Convert.ToDecimal(objRead["StudentIdNo"]),
                    Age = Convert.ToInt16(objRead["Age"]),
                    PhoneNumber = objRead["PhoneNumber"].ToString(),
                    StudentAddress = objRead["StudentAddress"].ToString(),
                    ClassId = Convert.ToInt16(objRead["ClassId"]),
                    ClassName = objRead["ClassName"].ToString(),             
                    CardNo = objRead["CardNo"].ToString()
                    
                };
            }
            objRead.Close();
            return objExtStudent;

        }
        #endregion
        #region 修改学员
        public int ModifyStudent(Students objStudent)
        {
            StringBuilder SqlBuilder = new StringBuilder();
            SqlBuilder.Append ("Update Students set StudentName='{0}',Gender='{1}',Birthday='{2}',StudentIdNo='{3}',");
            SqlBuilder.Append("Age={4},PhoneNumber='{5}',StudentAdderss='{6}',ClassId={7},ClassName='{8}',CardNo='{9}'");
            SqlBuilder.Append(" where StudentId={10}");
            //解析对象
            string sql = string.Format(SqlBuilder.ToString(),
                objStudent.StudentName, objStudent.Gender, objStudent.Birthday,
                objStudent.StudentIdNo, objStudent.Age, objStudent.PhoneNumber,
                objStudent.StudentAddress, objStudent.ClassId,objStudent.CardNo);
        }

        #endregion

    }
}
