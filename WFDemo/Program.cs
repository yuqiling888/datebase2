using StudentManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.Models;


namespace StudentManagermo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //插入登录窗口
            FrmUserLogin frmUserLogin = new FrmUserLogin();
            DialogResult result=frmUserLogin.ShowDialog();
            //判断登录是否成功
            if (result == DialogResult.OK)
            {
                Application.Run(new FrmDemo());
            }
            else
                Application.Exit();
        }

        //定义一个全局变量保存用户信息
        public static DAL.Models.SysAdmin ObjCurrentAdmin = null;
    }
}

//        using DAL;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


                //定义连接字符串
                //string connString = "Server=SC-202302051042\\TEW_SQL2019;Initial Catalog=StudentManageDB;Integrated Security=SSPI";
                ////创建连接对像
                //SqlConnection conn = new SqlConnection(connString);


                ////编写SQL语句
                //string sql = "select StudentId,StudentName,Gender from Students;select ClassId,ClassName from StudentClass";

                ////创建一个数据库连接实例
                //SqlCommand cmd = new SqlCommand(sql, conn);
                ////打开连接
                //conn.Open();

                ////用数据库读取器执行查询方法，返回DateReader对象
                //SqlDataReader objRader = cmd.ExecuteReader();


                //object result = cmd.ExecuteScalar();
                ///*读取一个返回数值的方法*/
                //Console.WriteLine("学生总数：" + result.ToString());


                /////*读取一个结果集的方法*/
                //////读取数据
                ////while (objRader.Read())
                ////{
                ////    Console.WriteLine(objRader["StudentId"].ToString() + "\t" + objRader["StudentName"].ToString() + "\t" + objRader["Gender"].ToString());
                ////}

                ///*读取多个结果集的方法*/
                ////读取第一个结果集
                //while (objRader.Read())
                //{
                //    Console.WriteLine(objRader["StudentId"].ToString() + "\t" + objRader["StudentName"].ToString() + "\t" + objRader["Gender"]);
                //}
                //Console.WriteLine("---------------------------------");
                ////判断是否有下一个结果集
                //if (objRader.NextResult())
                //{
                //    while (objRader.Read())
                //    {
                //        Console.WriteLine(objRader["ClassId"].ToString() + "\t" + objRader["ClassName"]);
                //    }

                //}

                //1.获取用户输入
                //Student student = new Student();
                //Console.WriteLine("请输入学生姓名");
                //student.StudentName = Console.ReadLine();
                //Console.WriteLine("请输入学生性别");
                //student.Gender = Console.ReadLine();
                //Console.WriteLine("请输入学生出生日期");
                //student.Birthday = Convert.ToDateTime(Console.ReadLine());
                //Console.WriteLine("请输入学生身份证号");
                //student.StudentIdNo = Convert.ToDecimal(Console.ReadLine());
                //Console.WriteLine("请输入年龄：");
                //student.Age = Convert.ToInt16(Console.ReadLine());
                //Console.WriteLine("请输入电话号码：");
                //student.PhoneNumber = Console.ReadLine();
                //Console.WriteLine("请输入地址");
                //student.StudentAddress = Console.ReadLine();
                //Console.WriteLine("请输入班级");
                //student.ClassId = Convert.ToInt16(Console.ReadLine());

                //StudentServer ObjstuSerive = new StudentServer();
                //int result = ObjstuSerive.AddStudent(student);
                //if (result == 1)
                //    Console.WriteLine("成功添加一个学员对象！");
                //else
                //    Console.WriteLine("对象添加失败！");
                //Console.ReadLine();

                ////调用数据访问方法获取数据
                //StudentServer objstudentServer = new StudentServer();
                //Console.WriteLine("请输入要查询的学号：");
                //            Student objStudent = objstudentServer.GetStuByStuId(Console.ReadLine());

                ////集合查询解析对象 
                //Console.WriteLine(objStudent.StudentName + "\t" + objStudent.Birthday.ToShortDateString() + "\t" + objStudent.Age + "\t" + objStudent.ClassId + "\t" + objStudent.PhoneNumber);
                //Console.ReadLine();

                //List<Student> list = objstudentServer.GetAllStudents();
                //if (list.Count != 0)
                //{
                //    foreach (Student item in list)
                //    {
                //        Console.WriteLine(item.StudentName + "\t" + item.Gender + "\t" + item.Age);
                //        Console.WriteLine("********************************");

                //    }
                //}
                //else
                //    Console.WriteLine("没有查询到！");
                //Console.ReadLine();

                ////组合扩展实体集合查询
                //StudentServer objstudentServer = new StudentServer();
                //List<StudentExt> ListExt = objstudentServer.GetAllStudetExt();
                ////解析组合扩展实体查询对象
                //foreach (StudentExt item in ListExt)
                //{
                //    Console.WriteLine(item.ObjStudent.StudentName + "\t" + item.ObjStudent.StudentIdNo + "\t" + item.ObjStudetClass.ClassName + "\t" + item.ObjStudentScore.Csharp);

                //}
                //Console.ReadLine();

                //简单扩展实体集合查询
                //StudentServer objstudentServer = new StudentServer();
                //List<StudentSimpleExt> ListSimpleExt = objstudentServer.StudentSimpleExt();
                ////解析组合扩展实体查询对象
                //foreach (StudentSimpleExt item in ListSimpleExt)
                //{
                //    Console.WriteLine(item.StudentName + "\t" + item.StudentIdNo + "\t" + item.ClassName + "\t");

                //}
                //Console.ReadLine();





                // //关闭读取器
                // objRader.Close();
                // conn.Close();

                // Console.ReadLine();



                //string sql = "select Count(*) from Students";
                //object result = SQLHelper.GetSingleResult(sql);
                //Console.WriteLine(result);
                //Console.ReadLine();

                //string sql = "update Students set StudentName='李晶晶' where StudentId=100000";
                //object result = SQLHelper.Update(sql);
                //Console.WriteLine(result);
                //Console.ReadLine();

                //string sql = "select StudentName from Students";
                //SqlDataReader objReader = SQLHelper.GetRead(sql);
                //while(objReader.Read())
                //{
                //    Console.WriteLine(objReader["StudentName"]);
                //}
                //objReader.Close();
                //Console.ReadLine();

                //string sql="insert into Students(StudentName,Gender,Birthday,StudentIdNo,";
                //sql += "Age,PhoneNumber,StudentAddress,ClassId)";
                //sql+="values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
                //sql = string.Format(sql, "刘俊华", "男", "1987-01-01", 120220197802045446, 28, "022-89895566", "天泽市河北区", 3);

                ////调用通用数据访问类
                //int result = SQLHelper.Update(sql);
                //if(result==1)
                //    {
                //    Console.WriteLine("添加成功");
                //    }
                //Console.ReadLine();




                //try
                //{
                //    using (var conn = new SqlConnection(connString))
                //    {
                //        conn.Open();
                //        // 只有在连接成功打开后，才能获取版本信息
                //        Console.WriteLine(conn.ServerVersion);
                //    }
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine($"连接失败: {ex.Message}");
                //}
                //Console.ReadLine();
    

    

