using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMCares.BMS.FDI.BLL
{
    public class DbOperate
    {
        private DAL.DbOperate dbOper = null;
        private DAL.DbOperate DbOper
        {
            get
            {
                if (dbOper == null)
                {
                    dbOper = new DAL.DbOperate();
                }
                return dbOper;
            }
        }
        public bool TestDbConn()
        {
            return DbOper.TestDbConn();
        }
    }
}
