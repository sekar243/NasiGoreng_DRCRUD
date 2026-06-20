using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    class DAL
    {
        public static string GetConnectionString()
        {
            string connctionString = $"Data Source={GetLoacalIPAddress()}Initial Catalog=DBAkademikADO;Integrated Security=True";
            return connctionString;
        }

        SqlConnection conn = new SqlConnection(GetConnectionString());
        SqlDataAdapter da;
        DataTable dtMahasiswa;
        DataTable dtProdi;

    }
}