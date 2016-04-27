using System;
using System.Windows.Forms;

namespace Tela_Entrada
{
    public partial class Tela_Entrada : Form
    {
        public Tela_Entrada()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Hide(); 
            Inserindo_Sistemas form = new Inserindo_Sistemas();
            form.ShowDialog();
            Close();
        }

           private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
