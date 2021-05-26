using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class SqlConn
    {
        public SqlDataReader rdr = null;
        public DataTable dtable = new DataTable();
        public SqlConnection con = null;
        public SqlCommand cmd = null;
        public DataSet ds;
        public SqlDataAdapter da;
    }
}
