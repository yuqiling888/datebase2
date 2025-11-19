using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentSimpleExt:Students
    {
        //班级名称
        public string ClassName { get; set; }
        //平均成绩
        public int AvgScore { get; set; }
    }
}
