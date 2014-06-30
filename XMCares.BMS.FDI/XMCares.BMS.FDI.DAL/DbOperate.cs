using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMCares.BMS.FDI.Common;

namespace XMCares.BMS.FDI.DAL
{
    public class DbOperate
    {
        private readonly string connStr = ConfigHelper.DbConnStr;
        public bool TestDbConn()
        {
            try
            {
                OracleHelper.ExecuteNonQuery(connStr, CommandType.Text, "select 1 from dual");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
