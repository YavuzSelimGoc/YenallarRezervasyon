using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YenallarRezervasyon
{
    public class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-S9DTQ5O\\MSSQLSERVERS;Initial Catalog=DBRezervasyon;Integrated Security=True");
            bgl.Open();
            return bgl;
        }
    }
}
