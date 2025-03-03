using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPmod03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string inputNama = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(inputNama))
            {
                label1.Text = "Halo, " + inputNama;
            }
            else
            {
                label1.Text = "Silakan masukkan nama!";
            }
        }
    }
}
