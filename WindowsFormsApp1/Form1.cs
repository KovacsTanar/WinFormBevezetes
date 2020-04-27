using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        { 
            //ha üres valamelyik textboxunk
            if(tb_bevitelEletkor.Text == "" || tb_bevitelNev.Text== "")
            {
                MessageBox.Show("Hiányos adatkitöltés!");
            }
            else
            {
                string nev = tb_bevitelNev.Text;
                int eletkor = Convert.ToInt32(tb_bevitelEletkor.Text);

                tb_udvozles.Text = "Üdvözlöm " + nev + "!";
                tb_kimenetEletkor.Text = "Az Ön életkora: " + eletkor;
            }

        }
    }
}
