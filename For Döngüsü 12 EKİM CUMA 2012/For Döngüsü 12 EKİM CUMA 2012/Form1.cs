using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace For_Döngüsü_12_EKİM_CUMA_2012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ba = int.Parse(textBox1.Text);
            int bt = int.Parse(textBox2.Text);
            for (int i = ba; i < bt; i++)
            
            { MessageBox.Show("Sezer"); }
            

        }
    }
}
