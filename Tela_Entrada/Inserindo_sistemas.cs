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
            TabControlSistemas.Appearance = TabAppearance.FlatButtons;
            TabControlSistemas.ItemSize = new Size(0, 1);
            TabControlSistemas.SizeMode = TabSizeMode.Fixed;

            lbTitulo1.Show();
            lbTitulo2.SendToBack();
            lbTitulo3.SendToBack();
        }

        //Botões:
            //Botões de Seguimento:
        private void btnProximo1_Click(object sender, EventArgs e)
        {           
            tabPage1.SendToBack();
            tabPage2.Show();

            lbTitulo1.SendToBack();
            lbTitulo3.SendToBack();
            lbTitulo2.Show();

            lbPesoFuncionabilidade1.Text = "Máximo de: " + tbFuncionabilidade.Text;
            lbPesoFuncionabilidade2.Text = "Máximo de: " + tbFuncionabilidade.Text;
            lbPesoConfiabilidade1.Text = "Máximo de: " + tbConfiabilidade.Text;
            lbPesoConfiabilidade2.Text = "Máximo de: " + tbConfiabilidade.Text;
            lbPesoUsabilidade1.Text = "Máximo de: " + tbUsabilidade.Text;
            lbPesoUsabilidade2.Text = "Máximo de: " + tbUsabilidade.Text;
            lbPesoEficiencia1.Text = "Máximo de: " + tbEficiencia.Text;
            lbPesoEficiencia2.Text = "Máximo de: " + tbEficiencia.Text;
            lbPesoManutenibilidade1.Text = "Máximo de: " + tbManutenibilidade.Text;
            lbPesoManutenibilidade2.Text = "Máximo de: " + tbManutenibilidade.Text;
            lbPesoPortabilidade1.Text = "Máximo de: " + tbPortabilidade.Text;
            lbPesoPortabilidade2.Text = "Máximo de: " + tbPortabilidade.Text;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularMedias();
            CalcularSomaMedias();                       

            try
            {
                MediaSistema1 = MediaSistema2;
            }
            catch
            {
                MessageBox.Show("Ambos os sistemas possuem pontuação final igual, cabendo ao usuário decidir qual é melhor utilizar para sua devida atividade.");
            }
            finally
            {
                lbTitulo1.SendToBack();
                lbTitulo2.SendToBack();
                lbTitulo3.Show();

                tabPage2.SendToBack();
                tabPage3.Show();
            }
            if (MediaSistema1 > MediaSistema2)
            {
                lbNotaFinal1.Text = "O sistema " + tbNomeSistema1.Text + " com " + MediaSistema1.ToString() + " pontos.";
            }
            if(MediaSistema2 > MediaSistema1)
            {
                lbNotaFinal1.Text = "O sistema " + tbNomeSistema2.Text + " com " + MediaSistema2.ToString() + " pontos.";
            }
        }

            //Botões de Finalização:
        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            lbTitulo1.Show();
            lbTitulo2.SendToBack();

            tabPage2.SendToBack();
            tabPage1.Show();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }




        public void CalcularMedias()
        {
            NotaFuncionabilidade1 = Convert.ToDouble(tbNotaFuncionabilidade1.Text) / Convert.ToDouble(tbFuncionabilidade.Text);
            NotaFuncionabilidade2 = Convert.ToDouble(tbNotaFuncionabilidade2.Text) / Convert.ToDouble(tbFuncionabilidade.Text);

            NotaConfiabilidade1 = Convert.ToDouble(tbNotaConfiabilidade1.Text) / Convert.ToDouble(tbConfiabilidade.Text);
            NotaConfiabilidade2 = Convert.ToDouble(tbNotaConfiabilidade2.Text) / Convert.ToDouble(tbConfiabilidade.Text);

            NotaUsabilidade1 = Convert.ToDouble(tbNotaUsabilidade1.Text) / Convert.ToDouble(tbUsabilidade.Text);
            NotaUsabilidade2 = Convert.ToDouble(tbNotaUsabilidade2.Text) / Convert.ToDouble(tbUsabilidade.Text);

            NotaEficiencia1 = Convert.ToDouble(tbNotaEficiencia1.Text) / Convert.ToDouble(tbEficiencia.Text);
            NotaEficiencia2 = Convert.ToDouble(tbNotaEficiencia2.Text) / Convert.ToDouble(tbEficiencia.Text);

            NotaManutenibilidade1 = Convert.ToDouble(tbNotaManutenibilidade1.Text) / Convert.ToDouble(tbManutenibilidade.Text);
            NotaManutenibilidade2 = Convert.ToDouble(tbNotaManutenibilidade2.Text) / Convert.ToDouble(tbManutenibilidade.Text);

            NotaPortabilidade1 = Convert.ToDouble(tbNotaPortabilidade1.Text) / Convert.ToDouble(tbPortabilidade.Text);
            NotaPortabilidade2 = Convert.ToDouble(tbNotaPortabilidade2.Text) / Convert.ToDouble(tbPortabilidade.Text);
        }

        public void CalcularSomaMedias()
        {
            MediaSistema1 = ((NotaFuncionabilidade1 + NotaConfiabilidade1 + NotaUsabilidade1 + NotaEficiencia1 + NotaManutenibilidade1 + NotaPortabilidade1) / 6);
            MediaSistema2 = ((NotaFuncionabilidade2 + NotaConfiabilidade2 + NotaUsabilidade2 + NotaEficiencia2+ NotaManutenibilidade2 + NotaPortabilidade2) / 6);
        }



        //Variáveis:
             //Nomes Sistemas:
        public string NomeSistema1;
        public string NomeSistema2;

            //Notas dos Parâmetros de cada Sistema:
        public double NotaFuncionabilidade1, NotaFuncionabilidade2;
        public double NotaConfiabilidade1, NotaConfiabilidade2;
        public double NotaUsabilidade1, NotaUsabilidade2;
        public double NotaEficiencia1, NotaEficiencia2;
        public double NotaManutenibilidade1, NotaManutenibilidade2;
        public double NotaPortabilidade1, NotaPortabilidade2;

        //Médias:
        public double MediaSistema1;
        public double MediaSistema2;
        
    }
}
