using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMCares.BMS.FDI.BLL
{
    public class Public
    {
        private DAL.Public dbOper = null;
        private DAL.Public DbOper
        {
            get
            {
                if (dbOper == null)
                {
                    dbOper = new DAL.Public();
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
