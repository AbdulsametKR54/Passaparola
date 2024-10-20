using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Passaparola
{
    internal class sqlConnect
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan=new SqlConnection("Data Source=AbdulsametKR\\SQLEXPRESS;Initial Catalog=PassaParolaDatabase;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
