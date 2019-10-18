using GatewayNome.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UsoGatewayNome.SqlCommands;

namespace GatewayNome {
    public partial class Home : Form {

        #region Attributes
        private string strSql = "";
        private string strCon = "";
        SqlConnection sqlCon = null;
        #endregion

        public Home() {
            InitializeComponent();
        }



        #region LoadData
        private void dtgLoadData() {

            try {

                ViewContratoGateway viewContratoGateway = new ViewContratoGateway();
                strSql = viewContratoGateway.VIEW_CONTRATO_GATEWAY_NOME;
                dtgView.DataSource = ExecuteReader(strSql);

            } catch (Exception) {

                throw;
            }
        }
        #endregion

        #region ExecuteReader
        private DataTable ExecuteReader(String Query) {
            DataTable dtTable = new DataTable();

            try {

                OpenSqlConnection openSqlConnection = new OpenSqlConnection();

                strCon = openSqlConnection.STRCON;
                sqlCon = new SqlConnection(strCon);
                SqlCommand command = new SqlCommand(Query, sqlCon);
                command.Parameters.Add("@matricula_aluno", SqlDbType.VarChar).Value = txtMatricula.Text;
                ExceptionTreatment();
                sqlCon.Open();
                command.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dtTable);

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);

            } finally {
                sqlCon.Close();
            }

            return dtTable;
        }
        #endregion

        #region ExceptionTreatment
        private void ExceptionTreatment() {

            try {

                if (txtMatricula.Text == string.Empty) {
                    throw new Exception("Você precisa digitar o ID do Aluno!");
                }

            } catch (Exception) {

                throw;
            }
        }
        #endregion

        #region TabButtons
        private void MnuSobre_Click(object sender, EventArgs e) {
            MessageBox.Show("Desenvolvido para o Financeiro extrair o GATEWAY de pagamento");

        }

        private void MnuAjuda_Click(object sender, EventArgs e) {
            AjudaFrm frmAjuda = new AjudaFrm();
            frmAjuda.Show();
        }

        #endregion

        #region EventHandlers
        private void BtnPesquisar_Click(object sender, EventArgs e) {

            dtgLoadData();
        }
        #endregion

        private void Home_Load(object sender, EventArgs e) {

        }
    }
}
