using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace InfMan2
{
    class ViewController
    {

        public static void showMenu()
        {
            hideAllItems();
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            lastOpenedForm.Controls["label1"].Visible = true;
            lastOpenedForm.Controls["button1"].Visible = true;
            lastOpenedForm.Controls["button2"].Visible = true;
        }

        public static void showGameOptions()
        {
            hideAllItems();
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            lastOpenedForm.Controls["label2"].Visible = true;
            lastOpenedForm.Controls["button3"].Visible = true;
            lastOpenedForm.Controls["button4"].Visible = true;
            lastOpenedForm.Controls["button5"].Visible = true;
        }

        public static void hideAllItems()
        {
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            ControlCollection controls = lastOpenedForm.Controls;
            foreach (Control control in controls)
            {
                control.Visible = false;
            }
        }

        public static void showHighscore()
        {
            hideAllItems();
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            lastOpenedForm.Controls["label3"].Visible = true;
            lastOpenedForm.Controls["label4"].Visible = true;
            lastOpenedForm.Controls["label5"].Visible = true;
            lastOpenedForm.Controls["label6"].Visible = true;
            lastOpenedForm.Controls["label7"].Visible = true;
            lastOpenedForm.Controls["label8"].Visible = true;
            lastOpenedForm.Controls["label9"].Visible = true;
            lastOpenedForm.Controls["label10"].Visible = true;
            lastOpenedForm.Controls["label11"].Visible = true;
            lastOpenedForm.Controls["label12"].Visible = true;
            lastOpenedForm.Controls["button5"].Visible = true;
            DataFiller.fillHighscore();
        }

        public static void startGamemode1()
        {
            hideAllItems();
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            lastOpenedForm.Controls["label13"].Visible = true;
            lastOpenedForm.Controls["label14"].Visible = true;
            lastOpenedForm.Controls["label15"].Visible = true;
            lastOpenedForm.Controls["button5"].Visible = true;
            lastOpenedForm.Controls["button6"].Visible = true;
            lastOpenedForm.Controls["button7"].Visible = true;
            GameManager.startGamemode1();
        }

        public static void startGamemode2()
        {
            hideAllItems();
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            lastOpenedForm.Controls["label13"].Visible = true;
            lastOpenedForm.Controls["label14"].Visible = true;
            lastOpenedForm.Controls["label15"].Visible = true;
            lastOpenedForm.Controls["button5"].Visible = true;
            lastOpenedForm.Controls["button9"].Visible = true;
            lastOpenedForm.Controls["button10"].Visible = true;
            lastOpenedForm.Controls["button11"].Visible = true;
            lastOpenedForm.Controls["button12"].Visible = true;
            GameManager.startGamemode2();
        }


        public static void showScore()
        {
            hideAllItems();
            Form lastOpenedForm = Application.OpenForms.Cast<Form>().Last();
            lastOpenedForm.Controls["label16"].Visible = true;
            lastOpenedForm.Controls["label17"].Visible = true;
            lastOpenedForm.Controls["label18"].Visible = true;
            lastOpenedForm.Controls["textBox1"].Visible = true;
            lastOpenedForm.Controls["button8"].Visible = true;

        }
    }
}
