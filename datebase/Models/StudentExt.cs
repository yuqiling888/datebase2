using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 组合扩展实体
    /// </summary>
    public class StudentExt
    {
        public StudentExt()
        {
            ObjStudent = new Students();
            ObjStudetClass = new StudentClass();
            ObjStudentScore = new StudentScore();
        }

        public Students ObjStudent { get; set; }
        public StudentClass ObjStudetClass { get; set; }
        public StudentScore ObjStudentScore { get; set; }
    }

    
}
