using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;//se importa la data
using System.Data.SqlClient;//se importa la data sql client
using System.Data.Sql; // se importa la data sql

namespace Tarea_1_modulo_2.models
{
    class Productos
    {

        SqlConnection conexion = new SqlConnection("Data Source=SQL7001.site4now.net;Initial Catalog=DB_A2ED31_itla;User ID=DB_A2ED31_itla_admin;Password=itla@2019");
        private DataSet ds;
        
       
    }   
}
