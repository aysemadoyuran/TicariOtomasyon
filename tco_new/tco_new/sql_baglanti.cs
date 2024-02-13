using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace tco_new
{
    class sql_baglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=***;Initial Catalog=db_ticari_otomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
