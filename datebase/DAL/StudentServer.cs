using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class StudentServer
    {
        /// <summary>
        /// 添加学员
        /// </summary>
        /// <param name="StudentName"></param>
        /// <param name="Gender"></param>
        /// <param name="Birthday"></param>
        /// <param name="StudentIdNo"></param>
        /// <param name="Age"></param>
        /// <param name="PhoneNumber"></param>
        /// <param name="StudentAddress"></param>
        /// <param name="ClassId"></param>
        /// <returns></returns>
        //public int AddStudent(string StudentName, string Gender, DateTime Birthday, string StudentIdNo, int Age,
        //    string PhoneNumber, string StudentAddress, int ClassId)
        //    {
        //    string sql = "insert into Students(StudentName,Gender,Birthday,StudentIdNo,";
        //    sql += "Age,PhoneNumber,StudentAddress,ClassId)";
        //    sql += "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
        //    sql = string.Format(sql,  StudentName,  Gender,  Birthday,  StudentIdNo,  Age,
        //     PhoneNumber,  StudentAddress,  ClassId);
        //    return SQLHelper.Update(sql);
        //    }
        //public int GetStuCountByClassId(string ClassId)
        //{
        //    string sql = "select count(*) from Students where ClassId=" + ClassId;
        //    return Convert.ToInt32(SQLHelper.GetSingleResult(sql));

        //}

        public int AddStudent(Students objStudent)
        {
            string sql = "insert into Students(StudentId,StudentName,Gender,Birthday,StudentIdNo,";
            sql += "Age,PhoneNumber,StudentAddress,ClassId)";
            sql += "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
            sql = string.Format(sql, objStudent.StudentName, objStudent.Gender, objStudent.Birthday, objStudent.StudentIdNo, objStudent.Age,
             objStudent.PhoneNumber, objStudent.StudentAddress, objStudent.ClassId);
            return SQLHelper.Update(sql);
        }
        public int GetStuCountByClassId(string ClassId)
        {
            string sql = "select count(*) from Students where ClassId=" + ClassId;
            return Convert.ToInt32(SQLHelper.GetSingleResult(sql));
        }
        public Students GetStuByStuId(string StudentId)
        { 
            //写SQL语句
            string sql = "select StudentName,Gender,Birthday,StudentIdNo,Age,PhoneNumber,StudentAddress,ClassId from Students where StudentId={0}";
            sql = string.Format(sql, StudentId);
            //执行查询
            SqlDataReader ObjRdead =SQLHelper.GetRead(sql);
            Students Objstudent = null;
            //读取数据
            if (ObjRdead.Read())
            {
                Objstudent = new Students()
                {
                    StudentName = ObjRdead["studentName"].ToString(),
                    Gender = ObjRdead["Gender"].ToString(),
                    Birthday = Convert.ToDateTime(ObjRdead["Birthday"]),
                    StudentIdNo = Convert.ToDecimal(ObjRdead["StudentIdNo"]),
                    Age = Convert.ToInt16(ObjRdead["Age"]),
                    PhoneNumber = ObjRdead["PhoneNumber"].ToString(),
                    StudentAddress = ObjRdead["StudentAddress"].ToString(),
                    ClassId = Convert.ToInt16(ObjRdead["ClassId"]),
                };
            }
            ObjRdead.Close();
            return Objstudent;
        }
        public List<Students> GetAllStudents()
        {
            string sql = "select StudentName,Gender,Birthday,StudentIdNo,Age,PhoneNumber,StudentAddress,ClassId from Students";
            SqlDataReader objReader = SQLHelper.GetRead(sql);
            List<Students> stuList = new List<Students>();
            while (objReader.Read())
            {
                Students ObjStu = new Students();
                ObjStu.StudentName = objReader["StudentName"].ToString();
                ObjStu.Gender = objReader["Gender"].ToString();
                ObjStu.Age = Convert.ToInt16(objReader["Age"]);
                ObjStu.PhoneNumber = objReader["PhoneNumber"].ToString();
                ObjStu.StudentAddress = objReader["StudentAddress"].ToString();
                ObjStu.ClassId = Convert.ToInt16(objReader["ClassId"]);
                //将学生对象添加到集合
                stuList.Add(ObjStu);
            }

            //while(objReader.Read())
            //{
            //    stuList.Add(b)
            //}

            //关闭读取器
            objReader.Close();

            return stuList;      
        }
        public List<StudentExt> GetAllStudetExt()
        {
            String sql = "select Students.StudentId,StudentName,StudentIdNo,Birthday,Age,StudentClass.ClassId,ClassName,Csharp from Students";
            sql += " inner join StudentClass on StudentClass.ClassId=Students.ClassId";
            sql += " inner join StudentScore on Students.StudentId=StudentScore.StudentId";
            //执行查询
            SqlDataReader ObjRead = SQLHelper.GetRead(sql);
            //创建扩展实体类集合的对象
            List<StudentExt> ObjListExt = new List<StudentExt>();

            //解板数据
            while (ObjRead.Read())
            {
                //创建扩展实体类的对象
                StudentExt ext = new StudentExt();
                ext.ObjStudent.StudentId = Convert.ToInt32(ObjRead["StudentId"]);
                ext.ObjStudent.StudentName = ObjRead["StudentName"].ToString();
                ext.ObjStudent.StudentIdNo = Convert.ToDecimal(ObjRead["StudentIdNo"]);
                ext.ObjStudetClass.ClassId = Convert.ToInt16(ObjRead["ClassId"]);
                ext.ObjStudetClass.ClassName = ObjRead["ClassName"].ToString();

                ext.ObjStudentScore.Csharp = ObjRead["Csharp"].ToString();


                ObjListExt.Add(ext);
            }
            ObjRead.Close();
            return ObjListExt;

        }

        /// <summary>
        /// 简单扩展实体
        /// </summary>
        /// <returns></returns>
        public List<StudentSimpleExt> StudentSimpleExt()
        {
            String sql = "select Students.StudentId,StudentName,StudentIdNo,ClassName,AvgScor=Csharp from Students";
            sql += " inner join StudentClass on StudentClass.ClassId=Students.ClassId";
            sql += " inner join StudentScore on Students.StudentId=StudentScore.StudentId";
            //执行查询
            SqlDataReader ObjRead = SQLHelper.GetRead(sql);
            //创建扩展实体类集合的对象
            List<StudentSimpleExt> ObjListSimpleExt = new List<StudentSimpleExt>();

            //解板数据
            while (ObjRead.Read())
            {

                //创建扩展实体类的对象
                ObjListSimpleExt.Add(new StudentSimpleExt()
                {                
                    StudentName = ObjRead["StudentName"].ToString(),
                     StudentIdNo = Convert.ToDecimal(ObjRead["StudentIdNo"]),
                     ClassName = ObjRead["ClassName"].ToString(),
                    AvgScore = Convert.ToInt32( ObjRead["AvgScor"])
                });
             }
            ObjRead.Close();
            return ObjListSimpleExt;

        }


    }
}