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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrivateFontCollection pfc = new PrivateFontCollection();     
            pfc.AddFontFile("Resources\\unispace.ttf");
            foreach (Control control in Controls)
            {
                control.Visible = false;

                if (control.GetType() == typeof(Label))
                {
                    control.Font = new Font(pfc.Families[0], control.Font.Size + 1);
                    
                }
                else if (control.GetType() == typeof(Button))
                {
                    control.Font = new Font(pfc.Families[0], control.Font.Size-2);
                    Button curButton = (Button) control;
                    var path = System.Environment.CurrentDirectory + "\\img\\buybutton.png";
                    string[] words = path.Split('\\');
                    var newPath = words[0] + "\\" + words[1] + "\\" + words[2] + "\\" + words[3] 
                                  + "\\" + words[4] + "\\" + words[7] + "\\" + words[8];

                    curButton.Image = new Bitmap(newPath);       
                    
                }


            }
            Button btnItem1 = (Button) Controls["button14"];
            Button btnItem2 = (Button) Controls["button15"];

            btnItem1.Image = default(Bitmap);
            btnItem2.Image = default(Bitmap);

            Controls["pictureBox1"].Visible = true;
            Controls["label1"].Visible = true;
            Controls["button1"].Visible = true;
            Controls["button2"].Visible = true;
            Controls["button13"].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewController.showGameOptions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewController.showHighscore();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewController.startGamemode1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewController.startGamemode2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GameManager.resetGame();
            ViewController.showMenu();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            int score = Int32.Parse(lastOpenedForm.Controls["label18"].Text);
            String username = lastOpenedForm.Controls["textBox1"].Text;
            DataFiller.storeScore(username, score);
            ViewController.showMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GameManager.clickedAnswerTrueFalse(true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GameManager.clickedAnswerTrueFalse(false);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GameManager.clickedABCD("A");
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            GameManager.clickedABCD("B");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GameManager.clickedABCD("C");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GameManager.clickedABCD("D");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            var shop = new Shop();
            shop.ShowDialog();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            String url = lastOpenedForm.Controls["label20"].Text;
            System.Diagnostics.Process.Start(url);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GameManager.extendTimer(10);
            Data.TotalExtenders -= 1;
            if (Data.TotalExtenders == 0)
            {
                Controls["button15"].Hide();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GameManager.extendTimer(5);
            Data.TotalTimeStops -= 1;

            if (Data.TotalTimeStops == 0)
            {
                Controls["button14"].Hide();
            }
        }
    }
}
