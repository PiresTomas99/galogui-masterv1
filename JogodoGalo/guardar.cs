using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodoGalo
{
    public partial class guardar : Form
    {
        string jogador;
        public guardar()
        {
            InitializeComponent();
        }

        private void guardar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            jogador = textBox1.Text;
            
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            Texto(jogador);
            this.Close();
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        public void Texto(string jogador)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("jogo.txt", true);
            file.WriteLine(jogador);
            file.Close();
        }

    }
}
