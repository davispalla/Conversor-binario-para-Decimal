using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BinarioParaDecimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1a. Parte: Aplicando 'placehold' para o campo de entrada 
            txt_Binario.Text = "Somente binários";


        }

        private void txt_Binario_Enter(object sender, EventArgs e)
        {
            //2a. Parte: Aplicando 'placehold' para o campo de entrada 
            if (txt_Binario.Text == "Somente binários")
            {
                txt_Binario.Text = "";
                txt_Binario.ForeColor = Color.Black;
            }
        }

        private void txt_Binario_Leave(object sender, EventArgs e)
        {
            //3a. Parte: Aplicando 'placehold' para o campo de entrada 
            if (txt_Binario.Text == "")
            {
                txt_Binario.Text = "Somente binários";
                txt_Binario.ForeColor = Color.Gray;
            }
        }

        private void txt_Binario_Click(object sender, EventArgs e)
        {

        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            //Logica para converter binario em decimal
            try
            {
                txt_Resultado.Text = Convert.ToInt32(txt_Binario.Text, 2).ToString();
            }
            catch (FormatException es)
            {
                MessageBox.Show($"Você não preencheu o campo BINÁRIO. Informe valores", es.Message);
            }

           
        }

        private void txt_Binario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Somente 0 ou 1;
            e.Handled = !("\b01".Contains(e.KeyChar));

        }

        private void txt_Binario_Validating(object sender, CancelEventArgs e)
        {
            // CASO O CAMPO FICAR EM BRANCO, EXIBIR ALERTA.
            if (txt_Binario.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txt_Binario, "Informe valores!");
            }
            else
                errorProvider1.SetError(txt_Binario, "");
        }
    }
}
