using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    /// <summary>
    /// 学员信息扩展实体
    /// </summary>
    public class ExtStudent:Students
    {
        public string ClassName { get; set; }
    }
}
