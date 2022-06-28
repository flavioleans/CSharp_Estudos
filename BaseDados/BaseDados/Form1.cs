using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgwLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
            string connectionString = "Data Source=LAPTOP-QONN332R;Database=master;Trusted_Connection=True";
            string comamandText = "CREATE DATABASE DbSqlServer";
            SqlConnection sqlConn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(comamandText, sqlConn);

            try
            {
                sqlConn.Open();
                // cmd.ExecuteNonQuery();
                labelResultado.Text = "Conectado ao SqlServer";
                labelResultado.BackColor = System.Drawing.Color.Blue;
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao Conectar com o SqlServer \n" + ex;
                labelResultado.BackColor = System.Drawing.Color.Red;

            }
            finally
            {
                sqlConn.Close();
            }

        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-QONN332R;Database=DbSqlServer;Trusted_Connection=True";
            string comamandText = "CREATE TABLE pessoas (id INT NOT NULL PRIMARY KEY, nome NVARCHAR(255), email NVARCHAR(255));";
            SqlConnection sqlConn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(comamandText, sqlConn);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                labelResultado.Text = "Tabela criada no SqlServer";
                labelResultado.BackColor = System.Drawing.Color.Blue;
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao Conectar com o SqlServer \n" + ex;
                labelResultado.BackColor = System.Drawing.Color.Red;

            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int id = new Random(DateTime.Now.Millisecond).Next(1, 100000);
            string nome = txtNome.Text.ToUpper();
            string email = txtEmail.Text.ToLower();

            string connectionString = "Data Source=LAPTOP-QONN332R;Database=DbSqlServer;Trusted_Connection=True";
            string comamandText = "INSERT INTO pessoas VALUES (" + id + ", '" + nome + "', '" + email + "')";
            SqlConnection sqlConn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(comamandText, sqlConn);

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                labelResultado.Text = "pessoa criada na tabela";
                labelResultado.BackColor = System.Drawing.Color.Blue;
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao criar a pessoa na tabela\n" + ex;
                labelResultado.BackColor = System.Drawing.Color.Red;

            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

            dgwLista.Rows.Clear();

            string connectionString = "Data Source=LAPTOP-QONN332R;Database=DbSqlServer;Trusted_Connection=True";
            SqlConnection sqlConn = new SqlConnection(connectionString);


            try
            {

                string comamandText = "SELECT * FROM pessoas";
                if (txtNome.Text != "")
                {
                    comamandText = "SELECT * FROM pessoas WHERE nome LIKE '%" + txtNome.Text.ToUpper() + "%'";

                }

                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comamandText, sqlConn);

                sqlConn.Open();
                sqlDataAdapter.Fill(dataTable);

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    dgwLista.Rows.Add(dataRow.ItemArray);
                }
                //labelResultado.Text = txtNome.Text;
                //labelResultado.BackColor = System.Drawing.Color.Blue;
            }
            catch (Exception ex)
            {
                dgwLista.Rows.Clear();
                labelResultado.Text = " pessoa não localizada na tabela\n" + ex;
                labelResultado.BackColor = System.Drawing.Color.Red;

            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=LAPTOP-QONN332R;Database=DbSqlServer;Trusted_Connection=True";
            SqlConnection sqlConn = new SqlConnection(connectionString);

            try
            {

                int id = (int)dgwLista.SelectedRows[0].Cells[0].Value;

                string comamandText = "DELETE FROM pessoas WHERE id = '" + id + "'";

                SqlCommand cmd = new SqlCommand(comamandText, sqlConn);


                sqlConn.Open();
                cmd.ExecuteNonQuery();
                labelResultado.Text = "Pessoa deletada com sucesso";
                labelResultado.BackColor = System.Drawing.Color.Blue;
                txtNome.Text = "";
                btnProcurar_Click(sender, e);
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao deletar a pessoa na tabela\n" + ex;
                labelResultado.BackColor = System.Drawing.Color.Red;

            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOP-QONN332R;Database=DbSqlServer;Trusted_Connection=True";
            SqlConnection sqlConn = new SqlConnection(connectionString);

            try
            {

                int id = (int)dgwLista.SelectedRows[0].Cells[0].Value;
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                string comamandText = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id LIKE '" + id + "'";

                SqlCommand cmd = new SqlCommand(comamandText, sqlConn);


                sqlConn.Open();
                cmd.ExecuteNonQuery();
                labelResultado.Text = "Pessoa alterado com sucesso";
                labelResultado.BackColor = System.Drawing.Color.Blue;
                txtNome.Text = "";
                txtEmail.Text = "";
                btnProcurar_Click(sender, e);
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao alterar a pessoa na tabela\n" + ex;
                labelResultado.BackColor = System.Drawing.Color.Red;

            }
            finally
            {
                sqlConn.Close();
            }
        }
    }

}
