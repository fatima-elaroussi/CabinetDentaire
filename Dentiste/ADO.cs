using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace Dentiste
{
    class ADO
    {
       public SqlConnection cn = new SqlConnection();
       public SqlCommand cmd = new SqlCommand();
       public SqlDataReader dr;
       public DataTable dt = new DataTable();
       public SqlDataAdapter da = new SqlDataAdapter();
       public DataSet ds = new DataSet();
      // public SqlCommandBuilder cmdb;
      // public DataRow dtr;

        public void connecter()
        {
            if(cn.State==ConnectionState.Closed || cn.State == ConnectionState.Broken)
            {
                cn.ConnectionString = "Data Source=DESKTOP-HKTMVBT;Initial Catalog=Dentiste2;Integrated Security=True";
                cn.Open();
            }
        }
        public void deconnecter()
        {
            if (cn.State == ConnectionState.Open )
            {
               
                cn.Close();
            }
        }
    }
}
