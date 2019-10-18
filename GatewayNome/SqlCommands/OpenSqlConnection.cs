using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoGatewayNome.SqlCommands {
    class OpenSqlConnection {

        public string STRCON = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=gestor2;Data Source=.\SQLEXPRESS";
        public string STRSQL = string.Empty;

    }
}
