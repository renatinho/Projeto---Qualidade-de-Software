using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tela_Entrada
{
    public partial class Inserindo_Sistemas : Form
    {
        public Inserindo_Sistemas()
        {
            InitializeComponent();
        }

        private void Inserindo_Sistemas_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }







    }
}
