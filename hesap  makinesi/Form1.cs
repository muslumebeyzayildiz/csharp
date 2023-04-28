using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap__makinesi
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = ( Button)sender;
            textBox1.Text += btn.Text;
        }

        private void Butonlar(object sender, EventArgs e)
        {

        }
    }
}
