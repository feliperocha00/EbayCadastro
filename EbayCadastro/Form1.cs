using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EbayCadastro
{
    public partial class Form1 : Form
    {
        Cadastro1 cad1 = new Cadastro1();
        Form2 form2 = new Form2();
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) Application.Exit();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (!(checkBox1.Checked))
            {
                MessageBox.Show("Você precisa aceitar os Termos e Políticas de Privacidade!", "Falha ao realizar cadastro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if((Nome.Text == "") || (Sobrenome.Text == "")||(Email.Text == "")||(Senha.Text == ""))
            {
                MessageBox.Show("Preencha os campos obrigatórios (*) e tente novamente.", "Falha ao finalizar cadastro.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            cad1.setNome(Nome.Text);
            cad1.setSobrenome(Sobrenome.Text);
            cad1.setEmail(Email.Text);
            cad1.setSenha(Senha.Text);

            form2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Nome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Nome_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
