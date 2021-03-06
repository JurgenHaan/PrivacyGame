﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }
            Controls["label1"].Visible = true;
            Controls["button1"].Visible = true;
            Controls["button2"].Visible = true;
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
    }
}
