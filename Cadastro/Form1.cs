using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        List<string> funcionarios = new List<string>();
        public Form1()
        {
            InitializeComponent();
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl.GetType().ToString().Equals("System.Windows.Forms.TextBox"))
                {
                    TextBox obj = (TextBox)ctrl;
                    obj.GotFocus += TextBoxGotFocus;
                    obj.LostFocus += TextBoxLostFocus;
                }
                else if (ctrl.GetType().ToString().Equals("System.Windows.Forms.ComboBox"))
                {
                    ComboBox obj = (ComboBox)ctrl;
                    obj.GotFocus += ComboBoxGotFocus;
                    obj.LostFocus += ComboBoxLostFocus;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl.GetType().ToString().Equals("System.Windows.Forms.TextBox"))
                {
                    TextBox obj = (TextBox)ctrl;
                    obj.Text = obj.Name;
                    obj.ForeColor = Color.Gray;
                }
                else if (ctrl.GetType().ToString().Equals("System.Windows.Forms.ComboBox"))
                {
                    ComboBox obj = (ComboBox)ctrl;
                    obj.Text = obj.Name;
                    obj.ForeColor = Color.Gray;
                }
            }
            Filhos.Text = "0";
        }
        private void TextBoxGotFocus(object sender, EventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if (obj.ForeColor != Color.Black)
            {
                obj.Text = "";
                obj.ForeColor = Color.Black;
            }
        }
        private void TextBoxLostFocus(object sender, EventArgs e)
        {
            TextBox obj = (TextBox)sender;
            if (obj.ForeColor == Color.Black && obj.Text == "")
            {
                obj.Text = obj.Name;
                obj.ForeColor = Color.Gray;
            }
        }
        private void ComboBoxGotFocus(object sender, EventArgs e)
        {
            ComboBox obj = (ComboBox)sender;
            if (obj.ForeColor != Color.Black)
            {
                obj.Text = "";
                obj.ForeColor = Color.Black;
            }
        }
        private void ComboBoxLostFocus(object sender, EventArgs e)
        {
            ComboBox obj = (ComboBox)sender;
            if (obj.ForeColor == Color.Black && obj.Text == "")
            {
                obj.Text = obj.Name;
                obj.ForeColor = Color.Gray;
            }
        }

        private void AprovadorText(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Impedir(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void AprovadorNum(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void ComboPlay(object sender, EventArgs e)
        {
            ComboBox t = sender as ComboBox;
            if (t.ForeColor != Color.Black)
                t.ForeColor = Color.Black;
        }

        private void TestAll(object sender, EventArgs e)
        {
            bool testar = false;
            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                if (ctrl.GetType().ToString().Equals("System.Windows.Forms.TextBox"))
                {
                    TextBox obj = (TextBox)ctrl;
                    if (obj.Text.Equals(obj.Name))
                    {
                        testar = true;
                        break;
                    }
                }
                else if (ctrl.GetType().ToString().Equals("System.Windows.Forms.ComboBox"))
                {
                    ComboBox obj = (ComboBox)ctrl;
                    if (obj.Text.Equals(obj.Name))
                    {
                        testar = true;
                        break;
                    }
                }
            }
            if (!testar) 
            {
               // List<string> pessoa = new List<string>();
               
                Funcionario pessoa = new Funcionario();

                pessoa.nome = Nome.Text;
                pessoa.nascimento = Dia.Text + "/" + Mês.Text + "/" + Ano.Text;
                pessoa.sexualidade = Sexualidade.Text;
                pessoa.profissão = Profissão.Text;
                pessoa.estadoCivil = EstadoCivil.Text;
                pessoa.pais = País.Text;
                pessoa.rg = RG.Text;
                pessoa.cidade = Cidade.Text;
                pessoa.rua = Rua.Text;
                pessoa.complemento = Complemento.Text;
                pessoa.n = int.Parse(Nº.Text);
                pessoa.ddd = int.Parse(DDD.Text);
                pessoa.tel = int.Parse(Telefone.Text);
                pessoa.email = Email.Text;
                pessoa.email_rest = Rest.Text;
                pessoa.sangue = Sangue.Text;
                pessoa.raca = Raça.Text;
                pessoa.nFilhos = int.Parse(Filhos.Text);
                funcionarios.Add(pessoa.nome + "#" + pessoa.nascimento + "#" + pessoa.sexualidade + "#" + pessoa.profissão + "#" +
                    pessoa.estadoCivil + "#" + pessoa.pais + "#" + pessoa.rg + "#" + pessoa.cidade + "#" + pessoa.rua + "#" +
                    pessoa.complemento + "#" + pessoa.n + "#" + pessoa.ddd + "#" + pessoa.tel + "#" + pessoa.email +
                    "#" + pessoa.email_rest + "#" + pessoa.sangue + "#" + pessoa.raca + "#" + pessoa.nFilhos);
                listBox1.Items.Add(pessoa.nome + "|" + pessoa.profissão + "|" + pessoa.pais);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Text.txt", true))
                {
                    file.WriteLine(funcionarios.Last());
                }
            }
            else
                MessageBox.Show("Preencha todas as informações."); 
        }

        private void Recuperar(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"Text.txt");
            string[] caracteristicas;
            foreach (string line in lines)
            {
                funcionarios.Add(line);
                caracteristicas = funcionarios.Last().Split('#','/');
                listBox1.Items.Add(caracteristicas[0] + "|" + caracteristicas[5] + "|" + caracteristicas[7]);
            }
        }

        private void Analise(object sender, EventArgs e)
        {
            string[] caracteristicas;
            int indexiaddo = listBox1.SelectedIndex;
            if (indexiaddo >= 0)
            {
                caracteristicas = funcionarios[indexiaddo].Split('#', '/');
                Nome.Text = caracteristicas[0];
                Dia.Text = caracteristicas[1];
                Mês.Text = caracteristicas[2];
                Ano.Text = caracteristicas[3];
                Sexualidade.Text = caracteristicas[4];
                Profissão.Text = caracteristicas[5];
                EstadoCivil.Text = caracteristicas[6];
                País.Text = caracteristicas[7];
                RG.Text = caracteristicas[8];
                Cidade.Text = caracteristicas[9];
                Rua.Text = caracteristicas[10];
                Complemento.Text = caracteristicas[11];
                Nº.Text = caracteristicas[12];
                DDD.Text = caracteristicas[13];
                Telefone.Text = caracteristicas[14];
                Email.Text = caracteristicas[15];
                Rest.Text = caracteristicas[16];
                Sangue.Text = caracteristicas[17];
                Raça.Text = caracteristicas[18];
                Filhos.Text = caracteristicas[19];
                foreach (Control ctrl in tableLayoutPanel1.Controls)
                {
                    if (ctrl.GetType().ToString().Equals("System.Windows.Forms.TextBox"))
                    {
                        TextBox obj = (TextBox)ctrl;
                        obj.ForeColor = Color.Black;
                    }
                    else if (ctrl.GetType().ToString().Equals("System.Windows.Forms.ComboBox"))
                    {
                        ComboBox obj = (ComboBox)ctrl;
                        obj.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void Check(object sender, EventArgs e)
        {
            string[] caracteristicas_toCheck;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                caracteristicas_toCheck = listBox1.Items[i].ToString().Split('|');
                if (caracteristicas_toCheck[0].Equals(Nome.Text) && 
                    caracteristicas_toCheck[1].Equals(Profissão.Text) &&
                    caracteristicas_toCheck[2].Equals(País.Text))
                    listBox1.SetSelected(i, true);
                //if )
            }
        }

        
    }
}
