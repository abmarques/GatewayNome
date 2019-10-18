using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoGatewayNome.SqlCommands {
    class ViewContratoGateway {

        public String VIEW_CONTRATO_GATEWAY_NOME = "select * from [comercial].[viw_contrato_uso_gateway] WHERE matricula_aluno = @matricula_aluno";

    }
}
