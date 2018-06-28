using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfMan2
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            this.Controls["label2"].Text = Data.TotalScore + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
