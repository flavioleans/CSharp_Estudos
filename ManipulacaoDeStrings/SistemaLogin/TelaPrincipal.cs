using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            while (CadastroUsuarios.UsuarioLogado == null)
            {
                Visible = false;
                f.ShowDialog();

                if (Form1.Cancelar)
                {
                    Application.Exit();
                    return;
                }
            }

            label1.Text = "Bem vindo(a) " + CadastroUsuarios.UsuarioLogado.Nome;
            Visible = true;
        }
    }
}
