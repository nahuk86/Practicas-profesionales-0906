using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DomainModel;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class D_Empleados
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);

        public DataTable MostrarEmpleados()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from empleados", cn);
            cn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            sdr.Close();
            cn.Close();
            return dt;
        }

    }
}
