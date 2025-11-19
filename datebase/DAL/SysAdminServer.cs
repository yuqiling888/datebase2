using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class AdminServer
    {
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            string sql = "select AdminName from Admins where LoginId={0}and LoginPwd='{1}'";
            sql=sql.
        }
    }
}
