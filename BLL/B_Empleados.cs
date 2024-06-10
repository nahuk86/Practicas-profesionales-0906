using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DomainModel;


namespace BLL
{
    public class B_Empleados
    {

        D_Empleados obj = new D_Empleados();

        public DataTable MostrarEmpleados()
        {
            return obj.MostrarEmpleados();
        }
  
    }
}
