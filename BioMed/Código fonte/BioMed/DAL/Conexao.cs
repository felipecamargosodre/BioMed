using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioMed.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PGMSA56;Initial Catalog=Usuarios;Integrated Security=True");
        public string endereco = @"Data Source=DESKTOP-PGMSA56;Initial Catalog=Usuarios;Integrated Security=True";

        public Conexao()
        {
        }

        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
