using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("Resources\\unispace.ttf");
            foreach (Control control in Controls)
            {
                //control.Font = new Font(pfc.Families[0], control.Font.Size - 3);
            }

            this.Controls["label2"].Text = Data.TotalScore + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //extra tijd
            int price = 100;
            if (Data.TotalScore >= price)
            {
                Data.TotalScore -= price;
                Data.TotalExtenders += 1;
                MessageBox.Show("Succesfully bought");
                Controls["label2"].Text = Data.TotalScore + "";
            }
            else
            {
                MessageBox.Show("Insufficient funds");
            }
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //skip vraag
            int price = 200;
            MessageBox.Show("Coming soon™");

            //if (Data.TotalScore >= price)
            //{
            //    Data.TotalScore -= price;
            //    Data.TotalSkips += 1;
            //    MessageBox.Show("Succesfully bought");
            //    Controls["label2"].Text = Data.TotalScore + "";

            //}
            //else
            //{
            //    MessageBox.Show("Insufficient funds");
            //}

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //tijd stoppen
            int price = 50;
            if (Data.TotalScore >= price)
            {
                Data.TotalScore -= price;
                Data.TotalTimeStops += 1;
                MessageBox.Show("Succesfully bought");
                Controls["label2"].Text = Data.TotalScore + "";
            }
            else
            {
                MessageBox.Show("Insufficient funds");
            }
        }
    }
}
